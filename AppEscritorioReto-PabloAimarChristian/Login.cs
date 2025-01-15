using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioReto_PabloAimarChristian
{
    public partial class Login : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private string usuario;
        private string contrasena;

        public Login()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple800, Primary.DeepPurple900, Primary.DeepPurple900, Accent.Yellow100, TextShade.WHITE);
            this.MaximizeBox = false;
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginComponente1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private async void btnAcceder_Click(object sender, EventArgs e)
        {

            usuario = inputUsuario.Text;
            contrasena = inputContrasena.Text;

            //Gestion gestion = new Gestion();
            //gestion.Show();
            //this.Hide();

            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "name", usuario },
                    { "password", contrasena }
                };

                var content = new StringContent(JsonConvert.SerializeObject(values), System.Text.Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://10.10.13.246:8080/api/login", content);

                var responseString = await response.Content.ReadAsStringAsync();

                if (responseString.Trim('"') == "OK")
                {
                    Gestion gestion = new Gestion();
                    gestion.Show();
                    this.Hide();
                }
                else
                {
                    labelErrorLogin.Text = "Usuario o contraseña incorrectos";
                    labelErrorLogin.ForeColor = ColorTranslator.FromHtml("#FF6666");
                    await ShakeControl(inputUsuario);
                    await ShakeControl(inputContrasena);
                }
            }
        }

        private async Task ShakeControl(Control control)
        {
            var originalLocation = control.Location;
            var rnd = new Random();
            const int shakeAmplitude = 10;
            const int shakeDuration = 300;
            const int shakeInterval = 20;

            for (int i = 0; i < shakeDuration / shakeInterval; i++)
            {
                var offsetX = rnd.Next(-shakeAmplitude, shakeAmplitude);
                control.Location = new Point(originalLocation.X + offsetX, originalLocation.Y);
                await Task.Delay(shakeInterval);
            }

            control.Location = originalLocation;
        }

    }
}
