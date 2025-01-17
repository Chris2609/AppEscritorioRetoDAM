using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace AppEscritorioReto_PabloAimarChristian
{
    public partial class Gestion : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public Gestion()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.DeepPurple800, Primary.DeepPurple900, Primary.DeepPurple900, Accent.Yellow100, TextShade.WHITE);
            this.MaximizeBox = false;
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            CargarListViewUsuarios();
        }

        private async void CargarListViewUsuarios()
        {
            materialListViewUsuarios.Items.Clear();
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://10.10.13.246:8080/api/usuarios");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);

                    foreach (var usuario in usuarios)
                    {
                        var item = new ListViewItem(new[] { usuario.Id.ToString(), usuario.Name, usuario.Admin.ToString() });
                        materialListViewUsuarios.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar los usuarios");
                }
            }
        }

        private async void CrearUsuario()
        {
            var usuario = new Usuario
            {
                Name = materialTextBoxUsuario.Text,
                Password = materialTextBoxPassword.Text,
                Admin = materialCheckboxAdmin.Checked
            };

            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "name", usuario.Name },
                    { "password", usuario.Password }
                };

                var content = new StringContent(JsonConvert.SerializeObject(values), System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://10.10.13.246:8080/api/usuarios", content);

                if (response.IsSuccessStatusCode)
                {
                    materialTextBoxUsuario.Text = "";
                    materialTextBoxPassword.Text = "";
                    materialCheckboxAdmin.Checked = false;
                    CargarListViewUsuarios();
                    MostrarAviso("avisoUsuarioCreado", 300);
                }
            }
        }

        private async void MostrarAviso(string elementoDesplazar, int cantDesplazar)
        {
            var aviso = this.Controls.Find(elementoDesplazar, true).FirstOrDefault() as Control;
            if (aviso != null)
            {
                int originalX = aviso.Location.X;
                int targetX = originalX - cantDesplazar;
                int duration = 200;
                int steps = 60;
                int delay = duration / steps;
                int displacementPerStep = cantDesplazar / steps;

                for (int i = 0; i < steps; i++)
                {
                    aviso.Location = new Point(aviso.Location.X - displacementPerStep, aviso.Location.Y);
                    await Task.Delay(delay);
                }

                await Task.Delay(1000);

                for (int i = 0; i < steps; i++)
                {
                    aviso.Location = new Point(aviso.Location.X + displacementPerStep, aviso.Location.Y);
                    await Task.Delay(delay);
                }

                aviso.Location = new Point(originalX, aviso.Location.Y);
            }
        }

        private async void ModificarUsuario()
        {
            var usuario = new Usuario
            {
                Id = int.Parse(materialTextBoxId.Text),
                Name = materialTextBoxUsuario.Text,
                Password = materialTextBoxPassword.Text,
                Admin = materialCheckboxAdmin.Checked
            };

            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "id", usuario.Id.ToString() },
                    { "name", usuario.Name },
                    { "password", usuario.Password }
                };
                var content = new StringContent(JsonConvert.SerializeObject(values), System.Text.Encoding.UTF8, "application/json");

                var request = new HttpRequestMessage(new HttpMethod("PATCH"), "http://10.10.13.246:8080/api/usuarios")
                {
                    Content = content
                };
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    materialTextBoxId.Text = "";
                    materialTextBoxUsuario.Text = "";
                    materialTextBoxPassword.Text = "";
                    materialCheckboxAdmin.Checked = false;
                    materialButtonGestionUsuarios.Text = "Crear";
                    CargarListViewUsuarios();
                    MostrarAviso("avisoUsuarioModificado", 400);
                }
            }
        }

        private void materialButtonGestionUsuarios_Click(object sender, EventArgs e)
        {
            if (materialButtonGestionUsuarios.Text == "Crear")
            {
                CrearUsuario();
            }
            else if (materialButtonGestionUsuarios.Text == "Modificar")
            {
                ModificarUsuario();
            }
        }

        private void materialListViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewUsuarios.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewUsuarios.SelectedItems[0];
                materialTextBoxId.Text = selectedItem.SubItems[0].Text;
                materialTextBoxUsuario.Text = selectedItem.SubItems[1].Text;
                materialCheckboxAdmin.Checked = bool.Parse(selectedItem.SubItems[2].Text);
                materialButtonGestionUsuarios.Text = "Modificar";
                materialButtonEliminarUsuario.Enabled = true;
            }
            else
            {
                materialTextBoxId.Text = "";
                materialTextBoxUsuario.Text = "";
                materialCheckboxAdmin.Checked = false;
                materialTextBoxPassword.Text = "";
                materialButtonGestionUsuarios.Text = "Crear";
                materialButtonEliminarUsuario.Enabled = false;
            }
        }

        private async void materialButtonEliminarUsuario_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var id = materialTextBoxId.Text;
                var response = await client.DeleteAsync($"http://10.10.13.246:8080/api/usuarios/{id}");

                if (response.IsSuccessStatusCode)
                {
                    materialTextBoxId.Text = "";
                    materialTextBoxUsuario.Text = "";
                    materialTextBoxPassword.Text = "";
                    materialCheckboxAdmin.Checked = false;
                    materialButtonEliminarUsuario.Enabled = false;
                    materialButtonGestionUsuarios.Text = "Crear";
                    CargarListViewUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario");
                }
            }
        }
    }
}
