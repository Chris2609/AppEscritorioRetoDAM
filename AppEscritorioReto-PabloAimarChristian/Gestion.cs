using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using ScottPlot;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Web.UI.WebControls;
using System.IO;

namespace AppEscritorioReto_PabloAimarChristian
{
    public partial class Gestion : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Login loginForm;

        public Gestion(Login loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;

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
            CargarListViewIncidencias();
            CargarSourcesComboBox();
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
            if (materialTextBoxUsuario.Text.Contains("@"))
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
                        string responseText = await response.Content.ReadAsStringAsync();
                        if (responseText.Trim('"') == "OK")
                        {
                            EnvioCorreo(materialTextBoxUsuario.Text);
                            materialTextBoxUsuario.Text = "";
                            materialTextBoxPassword.Text = "";
                            materialCheckboxAdmin.Checked = false;
                            labelFormatoUsuario.Text = "";
                            labelUsuarioDuplicado.Text = "";
                            CargarListViewUsuarios();
                            MostrarAviso("avisoUsuarioCreado", 300);
                        }
                        else if (responseText.Trim('"') == "NOT_FOUND")
                        {
                            labelFormatoUsuario.Text = "";
                            labelUsuarioDuplicado.Text = "Este usuario ya existe";
                        }
                    }
                }
            }
            else
            {
                labelUsuarioDuplicado.Text = "";
                labelFormatoUsuario.Text = "El formato del usuario no es correcto (ejemplo@dominio.com)";
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
                    MostrarAviso("avisoUsuarioEliminado", 360);
                    CargarListViewUsuarios();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario");
                }
            }
        }

        private void buttomLogOut_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void EnvioCorreo(string destinatario)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("reto2dam3@gmail.com", "yrql smhd swmx qiug"),
                EnableSsl = true,
            };

            var fecha = DateTime.Now.ToString("dd/MM/yyyy");
            var mensaje = $@"
                <html>
                <body>
                    <h1>Bienvenido a EuskoTrafico</h1>
                    <p>Su cuenta ha sido creada correctamente.</p>
                    <p>Fecha de creación: {fecha}</p>
                    <br>
                    <p>Gracias por unirse a nosotros.</p>
                    <br>
                    <p>&copy; 2025 EuskoTrafico. Todos los derechos reservados.</p>
                </body>
                </html>";

            var mailMessage = new MailMessage
            {
                From = new MailAddress("reto2dam3@gmail.com"),
                Subject = "Bienvenido a EuskoTrafico",
                Body = mensaje,
                IsBodyHtml = true,
            };

            mailMessage.To.Add(destinatario);

            smtpClient.Send(mailMessage);
        }

        private async void CargarListViewIncidencias()
        {
            materialListViewIncidencias.Items.Clear();
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://10.10.13.246:8080/api/incidences");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<Incidencia> incidencias = JsonConvert.DeserializeObject<List<Incidencia>>(json);

                    foreach (var incidencia in incidencias)
                    {
                        var item = new ListViewItem(new[] { incidencia.Id.ToString(), incidencia.AutonomousRegion, incidencia.CityTown, incidencia.Cause, incidencia.IncidenceType, incidencia.Province, incidencia.Latitude.ToString(), incidencia.Longitude.ToString(), incidencia.StartDate.Replace("T00:00:00", ""), incidencia.EndDate.Replace("T00:00:00", ""), incidencia.SourceId.ToString() });
                        materialListViewIncidencias.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Error al cargar las incidencias");
                }
            }
        }

        private async void CargarSourcesComboBox()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("http://10.10.13.246:8080/api/sources");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var sources = JsonConvert.DeserializeObject<List<dynamic>>(json);

                    var formattedSources = sources.Select(source => new
                    {
                        Display = $"{source.id}-{source.name}",
                        Value = source.id
                    }).ToList();

                    materialComboBoxIncSource.DisplayMember = "Display";
                    materialComboBoxIncSource.ValueMember = "Value";
                    materialComboBoxIncSource.DataSource = formattedSources;
                }
                else
                {
                    MessageBox.Show("Error al cargar las fuentes");
                }
            }
        }

        private void materialListViewIncidencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListViewIncidencias.SelectedItems.Count > 0)
            {
                var selectedItem = materialListViewIncidencias.SelectedItems[0];
                materialTextBoxIncId.Text = selectedItem.SubItems[0].Text;
                materialTextBoxIncReg.Text = selectedItem.SubItems[1].Text;
                materialTextBoxIncCiudad.Text = selectedItem.SubItems[2].Text;
                materialTextBoxIncCausa.Text = selectedItem.SubItems[3].Text;
                materialTextBoxIncTipo.Text = selectedItem.SubItems[4].Text;
                materialTextBoxIncProvincia.Text = selectedItem.SubItems[5].Text;
                materialTextBoxIncLat.Text = selectedItem.SubItems[6].Text;
                materialTextBoxIncLong.Text = selectedItem.SubItems[7].Text;
                materialTextBoxIncFechaInicio.Text = selectedItem.SubItems[8].Text;
                materialTextBoxIncFechaFin.Text = selectedItem.SubItems[9].Text;
                materialComboBoxIncSource.SelectedIndex = int.Parse(selectedItem.SubItems[10].Text) - 1;
                materialComboBoxIncSource.Refresh();
                materialButtonGestionarInc.Text = "Modificar";
                materialButtonEliminarInc.Enabled = true;
            }
            else
            {
                materialTextBoxIncId.Text = "";
                materialTextBoxIncReg.Text = "";
                materialTextBoxIncCiudad.Text = "";
                materialTextBoxIncCausa.Text = "";
                materialTextBoxIncTipo.Text = "";
                materialTextBoxIncProvincia.Text = "";
                materialTextBoxIncLat.Text = "";
                materialTextBoxIncLong.Text = "";
                materialTextBoxIncFechaInicio.Text = "";
                materialTextBoxIncFechaFin.Text = "";
                materialComboBoxIncSource.SelectedIndex = 0;
                materialComboBoxIncSource.Refresh();
                materialButtonGestionarInc.Text = "Crear";
                materialButtonEliminarInc.Enabled = false;
            }
        }

        private async void materialButtonEliminarInc_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var id = materialTextBoxIncId.Text;
                var response = await client.DeleteAsync($"http://10.10.13.246:8080/api/incidences/{id}");

                if (response.IsSuccessStatusCode)
                {
                    materialTextBoxIncId.Text = "";
                    materialTextBoxIncReg.Text = "";
                    materialTextBoxIncCiudad.Text = "";
                    materialTextBoxIncCausa.Text = "";
                    materialTextBoxIncTipo.Text = "";
                    materialTextBoxIncProvincia.Text = "";
                    materialTextBoxIncLat.Text = "";
                    materialTextBoxIncLong.Text = "";
                    materialTextBoxIncFechaInicio.Text = "";
                    materialTextBoxIncFechaFin.Text = "";
                    materialComboBoxIncSource.SelectedIndex = 0;
                    materialComboBoxIncSource.Refresh();
                    materialButtonGestionarInc.Text = "Crear";
                    materialButtonEliminarInc.Enabled = false;

                    MostrarAviso("avisoIncEliminada", 360);
                    CargarListViewIncidencias();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el usuario");
                }
            }
        }

        private void materialButtonGestionarInc_Click(object sender, EventArgs e)
        {
            if (materialButtonGestionarInc.Text == "Crear")
            {
                CrearIncidencia();
            }
            else if (materialButtonGestionarInc.Text == "Modificar")
            {
                ModificarIncidencia();
            }
        }

        private async void CrearIncidencia()
        {
            var incidencia = new Incidencia
            {
                AutonomousRegion = materialTextBoxIncReg.Text,
                CityTown = materialTextBoxIncCiudad.Text,
                Cause = materialTextBoxIncCausa.Text,
                IncidenceType = materialTextBoxIncTipo.Text,
                Province = materialTextBoxIncProvincia.Text,
                //Latitude = double.Parse(materialTextBoxIncLat.Text, System.Globalization.CultureInfo.InvariantCulture),
                //Longitude = double.Parse(materialTextBoxIncLong.Text, System.Globalization.CultureInfo.InvariantCulture),
                StartDate = materialTextBoxIncFechaInicio.Text,
                EndDate = materialTextBoxIncFechaFin.Text,
                SourceId = int.Parse(materialComboBoxIncSource.SelectedValue.ToString())
            };
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "autonomousRegion", incidencia.AutonomousRegion },
                    { "cityTown", incidencia.CityTown },
                    { "cause", incidencia.Cause },
                    { "incidenceType", incidencia.IncidenceType },
                    { "province", incidencia.Province },
                    { "latitude", materialTextBoxIncLat.Text.Replace(",", ".") },
                    { "longitude", materialTextBoxIncLong.Text.Replace(",", ".") },
                    { "startDate", incidencia.StartDate + "T00:00:00" },
                    { "endDate", incidencia.EndDate + "T00:00:00" },
                    { "sourceId", incidencia.SourceId.ToString() }
                };
                var content = new StringContent(JsonConvert.SerializeObject(values), System.Text.Encoding.UTF8, "application/json");
                var response = await client.PostAsync("http://10.10.13.246:8080/api/incidences", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseText = await response.Content.ReadAsStringAsync();
                    if (responseText.Trim('"') == "OK")
                    {
                        materialTextBoxIncReg.Text = "";
                        materialTextBoxIncCiudad.Text = "";
                        materialTextBoxIncCausa.Text = "";
                        materialTextBoxIncTipo.Text = "";
                        materialTextBoxIncProvincia.Text = "";
                        materialTextBoxIncLat.Text = "";
                        materialTextBoxIncLong.Text = "";
                        materialTextBoxIncFechaInicio.Text = "";
                        materialTextBoxIncFechaFin.Text = "";
                        materialComboBoxIncSource.SelectedIndex = 0;
                        materialComboBoxIncSource.Refresh();
                        CargarListViewIncidencias();
                        MostrarAviso("avisoIncCreada", 300);
                    }
                }
                else
                {
                    MessageBox.Show("Error al crear la incidencia: " + response.ReasonPhrase);
                }
            }
        }

        private void ModificarIncidencia()
        {
            var incidencia = new Incidencia
            {
                Id = int.Parse(materialTextBoxIncId.Text),
                AutonomousRegion = materialTextBoxIncReg.Text,
                CityTown = materialTextBoxIncCiudad.Text,
                Cause = materialTextBoxIncCausa.Text,
                IncidenceType = materialTextBoxIncTipo.Text,
                Province = materialTextBoxIncProvincia.Text,
                //Latitude = double.Parse(materialTextBoxIncLat.Text, System.Globalization.CultureInfo.InvariantCulture),
                //Longitude = double.Parse(materialTextBoxIncLong.Text, System.Globalization.CultureInfo.InvariantCulture),
                StartDate = materialTextBoxIncFechaInicio.Text,
                EndDate = materialTextBoxIncFechaFin.Text,
                SourceId = int.Parse(materialComboBoxIncSource.SelectedValue.ToString())
            };
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "id", incidencia.Id.ToString() },
                    { "autonomousRegion", incidencia.AutonomousRegion },
                    { "cityTown", incidencia.CityTown },
                    { "cause", incidencia.Cause },
                    { "incidenceType", incidencia.IncidenceType },
                    { "province", incidencia.Province },
                    { "latitude", materialTextBoxIncLat.Text.Replace(",", ".") },
                    { "longitude", materialTextBoxIncLong.Text.Replace(",", ".") },
                    { "startDate", incidencia.StartDate + "T00:00:00" },
                    { "endDate", incidencia.EndDate + "T00:00:00" },
                    { "sourceId", incidencia.SourceId.ToString() }
                };
                var content = new StringContent(JsonConvert.SerializeObject(values), System.Text.Encoding.UTF8, "application/json");
                var request = new HttpRequestMessage(new HttpMethod("PATCH"), "http://10.10.13.246:8080/api/incidences")
                {
                    Content = content
                };
                var response = client.SendAsync(request).Result;

                if (response.IsSuccessStatusCode)
                {
                    materialTextBoxIncId.Text = "";
                    materialTextBoxIncReg.Text = "";
                    materialTextBoxIncCiudad.Text = "";
                    materialTextBoxIncCausa.Text = "";
                    materialTextBoxIncTipo.Text = "";
                    materialTextBoxIncProvincia.Text = "";
                    materialTextBoxIncLat.Text = "";
                    materialTextBoxIncLong.Text = "";
                    materialTextBoxIncFechaInicio.Text = "";
                    materialTextBoxIncFechaFin.Text = "";
                    materialComboBoxIncSource.SelectedIndex = 0;
                    materialComboBoxIncSource.Refresh();
                    materialButtonGestionarInc.Text = "Crear";
                    materialButtonEliminarInc.Enabled = false;
                    CargarListViewIncidencias();
                    MostrarAviso("avisoIncModificada", 400);
                }
                else
                {
                    MessageBox.Show("Error al modificar la incidencia: " + response.ReasonPhrase);
                }
            }
        }

        private void buttonAbrirMapa_Click(object sender, EventArgs e)
        {
            Form mapaForm = new Form();
            mapaForm.Text = "Seleccionar ubicación";
            mapaForm.Size = new Size(800, 600);

            GMap.NET.WindowsForms.GMapControl gmap = new GMap.NET.WindowsForms.GMapControl();
            gmap.Dock = DockStyle.Fill;
            gmap.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;

            double latitud = 43.2632062544531;
            double longitud = -2.12860107421875;
            if (!string.IsNullOrEmpty(materialTextBoxIncLat.Text) && !string.IsNullOrEmpty(materialTextBoxIncLong.Text))
            {
                latitud = double.Parse(materialTextBoxIncLat.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                longitud = double.Parse(materialTextBoxIncLong.Text.Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                //MessageBox.Show(latitud.ToString(System.Globalization.CultureInfo.InvariantCulture) + " y " + longitud.ToString(System.Globalization.CultureInfo.InvariantCulture));
            }

            gmap.Position = new GMap.NET.PointLatLng(latitud, longitud);
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            gmap.Zoom = 10;
            gmap.CanDragMap = true;
            gmap.DragButton = MouseButtons.Middle;
            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gmap.IgnoreMarkerOnMouseWheel = true;

            GMap.NET.WindowsForms.GMapOverlay markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("markers");
            gmap.Overlays.Add(markersOverlay);

            GMap.NET.WindowsForms.GMapMarker marker = null;
            if (!string.IsNullOrEmpty(materialTextBoxIncLat.Text) && !string.IsNullOrEmpty(materialTextBoxIncLong.Text))
            {
                marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(latitud, longitud), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
                gmap.Overlays[0].Markers.Add(marker);
            }

            gmap.MouseClick += async (s, ev) =>
            {
                if (ev.Button == MouseButtons.Left)
                {
                    var point = gmap.FromLocalToLatLng(ev.X, ev.Y);
                    if (marker != null)
                    {
                        gmap.Overlays[0].Markers.Remove(marker);
                    }
                    marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(point, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
                    gmap.Overlays[0].Markers.Add(marker);

                    var client = new HttpClient();
                    client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Referer", "https://nominatim.openstreetmap.org/");
                    client.DefaultRequestHeaders.Add("Accept-Language", "es-ES,en;q=0.5");
                    var response = await client.GetAsync($"https://nominatim.openstreetmap.org/reverse?format=json&lat={point.Lat.ToString().Replace(",", ".")}&lon={point.Lng.ToString().Replace(",", ".")}");
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        dynamic locationData = JsonConvert.DeserializeObject(json);
                        materialTextBoxIncReg.Text = locationData.address.state;
                        materialTextBoxIncCiudad.Text = locationData.address.city ?? locationData.address.town ?? locationData.address.village;
                        materialTextBoxIncProvincia.Text = locationData.address.province ?? locationData.address.state;
                    }
                }
            };

            MaterialButton confirmButton = new MaterialButton();
            confirmButton.Text = "Confirmar";
            confirmButton.Dock = DockStyle.Bottom;
            confirmButton.Click += (s, ev) =>
            {
                if (marker != null)
                {
                    materialTextBoxIncLat.Text = marker.Position.Lat.ToString();
                    materialTextBoxIncLong.Text = marker.Position.Lng.ToString();
                }
                mapaForm.Close();
            };

            mapaForm.Controls.Add(gmap);
            mapaForm.Controls.Add(confirmButton);
            mapaForm.ShowDialog();
        }

        private void GenerarPDFConGraficos(object sender, EventArgs e)
        {
            // Obtener datos del ListView
            var incidencias = new List<Incidencia>();
            foreach (ListViewItem item in materialListViewIncidencias.Items)
            {
                var incidencia = new Incidencia
                {
                    Id = int.Parse(item.SubItems[0].Text),
                    AutonomousRegion = item.SubItems[1].Text,
                    CityTown = item.SubItems[2].Text,
                    Cause = item.SubItems[3].Text,
                    IncidenceType = item.SubItems[4].Text,
                    Province = item.SubItems[5].Text,
                    Latitude = double.Parse(item.SubItems[6].Text),
                    Longitude = double.Parse(item.SubItems[7].Text),
                    StartDate = item.SubItems[8].Text,
                    EndDate = item.SubItems[9].Text,
                    SourceId = int.Parse(item.SubItems[10].Text)
                };
                incidencias.Add(incidencia);
            }

            // Crear gráficos con ScottPlot
            string rutaGraficoBarras = GenerarGraficoBarras(incidencias);
            string rutaGraficoPastel = GenerarGraficoPastel(incidencias);
            string rutaGraficoDuracion = GenerarGraficoDuracion(incidencias);

            // Crear el PDF con iTextSharp
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaPDF = Path.Combine(rutaDocumentos, "Reporte_Incidencias.pdf");
            using (var document = new Document())
            {
                PdfWriter.GetInstance(document, new FileStream(rutaPDF, FileMode.Create));
                document.Open();

                // Añadir título
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                document.Add(new Paragraph("Reporte de Incidencias", titleFont));
                document.Add(new Paragraph($"Fecha de Generación: {DateTime.Now:dd/MM/yyyy}\n\n"));

                // Añadir primer gráfico (Barras)
                document.Add(new Paragraph("Gráfico 1: Incidencias por Ciudad/Pueblo\n", titleFont));
                var imagenGraficoBarras = iTextSharp.text.Image.GetInstance(rutaGraficoBarras);
                imagenGraficoBarras.ScaleToFit(500, 300);
                document.Add(imagenGraficoBarras);
                document.Add(new Paragraph("\n"));

                // Añadir segundo gráfico (Pastel)
                document.Add(new Paragraph("Gráfico 2: Incidencias por Región Autónoma\n", titleFont));
                var imagenGraficoPastel = iTextSharp.text.Image.GetInstance(rutaGraficoPastel);
                imagenGraficoPastel.ScaleToFit(500, 300);
                document.Add(imagenGraficoPastel);
                document.Add(new Paragraph("\n"));

                // Añadir tercer gráfico (Duración de incidencias)
                document.Add(new Paragraph("Gráfico 3: Duración de Incidencias\n", titleFont));
                var imagenGraficoDuracion = iTextSharp.text.Image.GetInstance(rutaGraficoDuracion);
                imagenGraficoDuracion.ScaleToFit(500, 300);
                document.Add(imagenGraficoDuracion);

                document.Close();
            }

            // Mostrar la ruta en la que se ha guardado
            MessageBox.Show("El archivo se ha guardado en: " + rutaPDF);
        }

        private string GenerarGraficoBarras(List<Incidencia> incidencias)
        {
            // Agrupar por ciudad/pueblo
            var grouped = incidencias.GroupBy(i => i.CityTown)
                                     .Select(g => new { City = g.Key, Count = g.Count() })
                                     .ToList();

            double[] values = grouped.Select(g => (double)g.Count).ToArray();
            string[] labels = grouped.Select(g => g.City).ToArray();

            // Crear el gráfico
            var plt = new ScottPlot.Plot(600, 400);
            plt.AddBar(values);
            plt.XTicks(labels);
            plt.Title("Incidencias por Ciudad/Pueblo");
            plt.YLabel("Cantidad");

            // Guardar como imagen
            string ruta = "Grafico_Barras.png";
            plt.SaveFig(ruta);
            return ruta;
        }

        private string GenerarGraficoPastel(List<Incidencia> incidencias)
        {
            // Agrupar por región autónoma
            var grouped = incidencias.GroupBy(i => i.AutonomousRegion)
                                     .Select(g => new { Region = g.Key, Count = g.Count() })
                                     .ToList();

            double[] values = grouped.Select(g => (double)g.Count).ToArray();
            string[] labels = grouped.Select(g => g.Region).ToArray();

            // Crear el gráfico
            var plt = new ScottPlot.Plot(600, 400);
            var pie = plt.AddPie(values);
            pie.SliceLabels = labels;
            pie.ShowPercentages = true;

            // Agregar leyenda
            plt.Legend(location: ScottPlot.Alignment.UpperLeft);
            plt.Title("Incidencias por Región Autónoma");

            // Guardar como imagen
            string ruta = "Grafico_Pastel.png";
            plt.SaveFig(ruta);
            return ruta;
        }

        private string GenerarGraficoDuracion(List<Incidencia> incidencias)
        {
            // Convertir las fechas de inicio y fin a DateTime y calcular duración
            var durations = incidencias.Select(i => new
            {
                Id = i.Id,
                StartDate = DateTime.Parse(i.StartDate),
                EndDate = DateTime.Parse(i.EndDate),
                Duration = (DateTime.Parse(i.EndDate) - DateTime.Parse(i.StartDate)).Days
            }).ToList();

            // Ordenar por fecha de inicio
            durations = durations.OrderBy(d => d.StartDate).ToList();

            // Valores de duración
            double[] values = durations.Select(d => (double)d.Duration).ToArray();

            // Etiquetas combinadas: "ID \n FechaInicio → FechaFin"
            string[] labels = durations.Select(d => $"ID {d.Id}\n{d.StartDate:yyyy-MM-dd} → {d.EndDate:yyyy-MM-dd}").ToArray();

            // Crear el gráfico
            var plt = new ScottPlot.Plot(800, 500);

            // Añadir barras horizontales
            var bar = plt.AddBar(values);
            bar.Orientation = ScottPlot.Orientation.Horizontal;

            // Configurar eje Y con etiquetas de ID + Fechas
            plt.YTicks(labels);
            plt.Title("Duración de Incidencias");
            plt.XLabel("Duración (días)");

            // Guardar como imagen
            string ruta = "Grafico_Duracion.png";
            plt.SaveFig(ruta);
            return ruta;
        }
    }
}
