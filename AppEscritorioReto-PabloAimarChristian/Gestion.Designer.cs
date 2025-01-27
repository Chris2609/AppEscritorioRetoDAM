namespace AppEscritorioReto_PabloAimarChristian
{
    partial class Gestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestion));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelUsuarioDuplicado = new System.Windows.Forms.Label();
            this.avisoUsuarioEliminado = new AppEscritorioRetoDAM.UsuarioEliminado();
            this.avisoUsuarioModificado = new AppEscritorioRetoDAM.AvisoUsuarioModificado();
            this.avisoUsuarioCreado = new AppEscritorioRetoDAM.AvisoUsuarioCreado();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButtonEliminarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxId = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialListViewUsuarios = new MaterialSkin.Controls.MaterialListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAdmin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCheckboxAdmin = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTextBoxUsuario = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonGestionUsuarios = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabelFormatoFecha = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonEliminarInc = new MaterialSkin.Controls.MaterialButton();
            this.materialButtonGestionarInc = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxIncFechaFin = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncLong = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncFechaInicio = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialComboBoxIncSource = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxIncLat = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncTipo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncProvincia = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncCausa = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncReg = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncCiudad = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxIncId = new MaterialSkin.Controls.MaterialTextBox2();
            this.avisoIncEliminada = new AppEscritorioRetoDAM.AvisoIncEliminada();
            this.avisoIncModificada = new AppEscritorioRetoDAM.AvisoIncModificada();
            this.avisoIncCreada = new AppEscritorioRetoDAM.AvisoIncCreada();
            this.materialListViewIncidencias = new MaterialSkin.Controls.MaterialListView();
            this.columnIncId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncAutonomousRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncCityTown = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncCause = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncIncidendeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncProvince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncLat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncLong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIncSourceId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.buttomLogOut = new System.Windows.Forms.Button();
            this.loginComponente1 = new AppEscritorioRetoDAM.LoginComponente();
            this.buttonAbrirMapa = new System.Windows.Forms.Button();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.iconos;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(797, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelUsuarioDuplicado);
            this.tabPage1.Controls.Add(this.avisoUsuarioEliminado);
            this.tabPage1.Controls.Add(this.avisoUsuarioModificado);
            this.tabPage1.Controls.Add(this.avisoUsuarioCreado);
            this.tabPage1.Controls.Add(this.materialTextBoxPassword);
            this.tabPage1.Controls.Add(this.materialButtonEliminarUsuario);
            this.tabPage1.Controls.Add(this.materialTextBoxId);
            this.tabPage1.Controls.Add(this.materialListViewUsuarios);
            this.tabPage1.Controls.Add(this.materialCheckboxAdmin);
            this.tabPage1.Controls.Add(this.materialTextBoxUsuario);
            this.tabPage1.Controls.Add(this.materialButtonGestionUsuarios);
            this.tabPage1.ImageKey = "iconoGestionUsuarios.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelUsuarioDuplicado
            // 
            this.labelUsuarioDuplicado.AutoSize = true;
            this.labelUsuarioDuplicado.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.labelUsuarioDuplicado.ForeColor = System.Drawing.Color.Red;
            this.labelUsuarioDuplicado.Location = new System.Drawing.Point(413, 85);
            this.labelUsuarioDuplicado.Name = "labelUsuarioDuplicado";
            this.labelUsuarioDuplicado.Size = new System.Drawing.Size(0, 19);
            this.labelUsuarioDuplicado.TabIndex = 13;
            // 
            // avisoUsuarioEliminado
            // 
            this.avisoUsuarioEliminado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoUsuarioEliminado.Location = new System.Drawing.Point(837, 9);
            this.avisoUsuarioEliminado.Name = "avisoUsuarioEliminado";
            this.avisoUsuarioEliminado.Size = new System.Drawing.Size(259, 66);
            this.avisoUsuarioEliminado.TabIndex = 12;
            // 
            // avisoUsuarioModificado
            // 
            this.avisoUsuarioModificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoUsuarioModificado.Location = new System.Drawing.Point(833, 9);
            this.avisoUsuarioModificado.Name = "avisoUsuarioModificado";
            this.avisoUsuarioModificado.Size = new System.Drawing.Size(278, 66);
            this.avisoUsuarioModificado.TabIndex = 11;
            // 
            // avisoUsuarioCreado
            // 
            this.avisoUsuarioCreado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoUsuarioCreado.ForeColor = System.Drawing.Color.White;
            this.avisoUsuarioCreado.Location = new System.Drawing.Point(796, 9);
            this.avisoUsuarioCreado.Name = "avisoUsuarioCreado";
            this.avisoUsuarioCreado.Size = new System.Drawing.Size(238, 66);
            this.avisoUsuarioCreado.TabIndex = 10;
            // 
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.Hint = "Contraseña";
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(442, 170);
            this.materialTextBoxPassword.MaxLength = 50;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Multiline = false;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.Password = true;
            this.materialTextBoxPassword.Size = new System.Drawing.Size(221, 36);
            this.materialTextBoxPassword.TabIndex = 9;
            this.materialTextBoxPassword.Text = "";
            this.materialTextBoxPassword.TrailingIcon = null;
            this.materialTextBoxPassword.UseTallSize = false;
            // 
            // materialButtonEliminarUsuario
            // 
            this.materialButtonEliminarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEliminarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonEliminarUsuario.Depth = 0;
            this.materialButtonEliminarUsuario.Enabled = false;
            this.materialButtonEliminarUsuario.HighEmphasis = false;
            this.materialButtonEliminarUsuario.Icon = null;
            this.materialButtonEliminarUsuario.Location = new System.Drawing.Point(575, 297);
            this.materialButtonEliminarUsuario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEliminarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEliminarUsuario.Name = "materialButtonEliminarUsuario";
            this.materialButtonEliminarUsuario.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonEliminarUsuario.Size = new System.Drawing.Size(88, 36);
            this.materialButtonEliminarUsuario.TabIndex = 7;
            this.materialButtonEliminarUsuario.Text = "Eliminar";
            this.materialButtonEliminarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEliminarUsuario.UseAccentColor = false;
            this.materialButtonEliminarUsuario.UseVisualStyleBackColor = true;
            this.materialButtonEliminarUsuario.Click += new System.EventHandler(this.materialButtonEliminarUsuario_Click);
            // 
            // materialTextBoxId
            // 
            this.materialTextBoxId.AnimateReadOnly = false;
            this.materialTextBoxId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxId.Depth = 0;
            this.materialTextBoxId.Enabled = false;
            this.materialTextBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxId.HideSelection = true;
            this.materialTextBoxId.Hint = "ID";
            this.materialTextBoxId.LeadingIcon = null;
            this.materialTextBoxId.Location = new System.Drawing.Point(442, 39);
            this.materialTextBoxId.MaxLength = 32767;
            this.materialTextBoxId.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxId.Name = "materialTextBoxId";
            this.materialTextBoxId.PasswordChar = '\0';
            this.materialTextBoxId.PrefixSuffixText = null;
            this.materialTextBoxId.ReadOnly = true;
            this.materialTextBoxId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxId.SelectedText = "";
            this.materialTextBoxId.SelectionLength = 0;
            this.materialTextBoxId.SelectionStart = 0;
            this.materialTextBoxId.ShortcutsEnabled = true;
            this.materialTextBoxId.Size = new System.Drawing.Size(221, 36);
            this.materialTextBoxId.TabIndex = 6;
            this.materialTextBoxId.TabStop = false;
            this.materialTextBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxId.TrailingIcon = null;
            this.materialTextBoxId.UseSystemPasswordChar = false;
            this.materialTextBoxId.UseTallSize = false;
            // 
            // materialListViewUsuarios
            // 
            this.materialListViewUsuarios.AutoSizeTable = false;
            this.materialListViewUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnNombre,
            this.columnAdmin});
            this.materialListViewUsuarios.Depth = 0;
            this.materialListViewUsuarios.FullRowSelect = true;
            this.materialListViewUsuarios.HideSelection = false;
            this.materialListViewUsuarios.LabelWrap = false;
            this.materialListViewUsuarios.Location = new System.Drawing.Point(6, 3);
            this.materialListViewUsuarios.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewUsuarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewUsuarios.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewUsuarios.MultiSelect = false;
            this.materialListViewUsuarios.Name = "materialListViewUsuarios";
            this.materialListViewUsuarios.OwnerDraw = true;
            this.materialListViewUsuarios.Size = new System.Drawing.Size(327, 379);
            this.materialListViewUsuarios.TabIndex = 5;
            this.materialListViewUsuarios.UseCompatibleStateImageBehavior = false;
            this.materialListViewUsuarios.View = System.Windows.Forms.View.Details;
            this.materialListViewUsuarios.SelectedIndexChanged += new System.EventHandler(this.materialListViewUsuarios_SelectedIndexChanged);
            // 
            // columnId
            // 
            this.columnId.Text = "ID";
            this.columnId.Width = 65;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 170;
            // 
            // columnAdmin
            // 
            this.columnAdmin.Text = "Admin";
            this.columnAdmin.Width = 92;
            // 
            // materialCheckboxAdmin
            // 
            this.materialCheckboxAdmin.AutoSize = true;
            this.materialCheckboxAdmin.Depth = 0;
            this.materialCheckboxAdmin.Enabled = false;
            this.materialCheckboxAdmin.Location = new System.Drawing.Point(502, 230);
            this.materialCheckboxAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxAdmin.Name = "materialCheckboxAdmin";
            this.materialCheckboxAdmin.ReadOnly = false;
            this.materialCheckboxAdmin.Ripple = true;
            this.materialCheckboxAdmin.Size = new System.Drawing.Size(81, 37);
            this.materialCheckboxAdmin.TabIndex = 4;
            this.materialCheckboxAdmin.Text = "Admin";
            this.materialCheckboxAdmin.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxUsuario
            // 
            this.materialTextBoxUsuario.AnimateReadOnly = false;
            this.materialTextBoxUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxUsuario.Depth = 0;
            this.materialTextBoxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxUsuario.HideSelection = true;
            this.materialTextBoxUsuario.Hint = "Usuario";
            this.materialTextBoxUsuario.LeadingIcon = null;
            this.materialTextBoxUsuario.Location = new System.Drawing.Point(442, 107);
            this.materialTextBoxUsuario.MaxLength = 32767;
            this.materialTextBoxUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxUsuario.Name = "materialTextBoxUsuario";
            this.materialTextBoxUsuario.PasswordChar = '\0';
            this.materialTextBoxUsuario.PrefixSuffixText = null;
            this.materialTextBoxUsuario.ReadOnly = false;
            this.materialTextBoxUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxUsuario.SelectedText = "";
            this.materialTextBoxUsuario.SelectionLength = 0;
            this.materialTextBoxUsuario.SelectionStart = 0;
            this.materialTextBoxUsuario.ShortcutsEnabled = true;
            this.materialTextBoxUsuario.Size = new System.Drawing.Size(221, 36);
            this.materialTextBoxUsuario.TabIndex = 2;
            this.materialTextBoxUsuario.TabStop = false;
            this.materialTextBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxUsuario.TrailingIcon = null;
            this.materialTextBoxUsuario.UseSystemPasswordChar = false;
            this.materialTextBoxUsuario.UseTallSize = false;
            // 
            // materialButtonGestionUsuarios
            // 
            this.materialButtonGestionUsuarios.AutoSize = false;
            this.materialButtonGestionUsuarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGestionUsuarios.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGestionUsuarios.Depth = 0;
            this.materialButtonGestionUsuarios.HighEmphasis = true;
            this.materialButtonGestionUsuarios.Icon = null;
            this.materialButtonGestionUsuarios.Location = new System.Drawing.Point(442, 297);
            this.materialButtonGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonGestionUsuarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGestionUsuarios.Name = "materialButtonGestionUsuarios";
            this.materialButtonGestionUsuarios.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGestionUsuarios.Size = new System.Drawing.Size(88, 36);
            this.materialButtonGestionUsuarios.TabIndex = 1;
            this.materialButtonGestionUsuarios.Text = "Crear";
            this.materialButtonGestionUsuarios.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGestionUsuarios.UseAccentColor = false;
            this.materialButtonGestionUsuarios.UseVisualStyleBackColor = true;
            this.materialButtonGestionUsuarios.Click += new System.EventHandler(this.materialButtonGestionUsuarios_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAbrirMapa);
            this.tabPage2.Controls.Add(this.materialLabelFormatoFecha);
            this.tabPage2.Controls.Add(this.materialButtonEliminarInc);
            this.tabPage2.Controls.Add(this.materialButtonGestionarInc);
            this.tabPage2.Controls.Add(this.materialTextBoxIncFechaFin);
            this.tabPage2.Controls.Add(this.materialTextBoxIncLong);
            this.tabPage2.Controls.Add(this.materialTextBoxIncFechaInicio);
            this.tabPage2.Controls.Add(this.materialComboBoxIncSource);
            this.tabPage2.Controls.Add(this.materialTextBoxIncLat);
            this.tabPage2.Controls.Add(this.materialTextBoxIncTipo);
            this.tabPage2.Controls.Add(this.materialTextBoxIncProvincia);
            this.tabPage2.Controls.Add(this.materialTextBoxIncCausa);
            this.tabPage2.Controls.Add(this.materialTextBoxIncReg);
            this.tabPage2.Controls.Add(this.materialTextBoxIncCiudad);
            this.tabPage2.Controls.Add(this.materialTextBoxIncId);
            this.tabPage2.Controls.Add(this.avisoIncEliminada);
            this.tabPage2.Controls.Add(this.avisoIncModificada);
            this.tabPage2.Controls.Add(this.avisoIncCreada);
            this.tabPage2.Controls.Add(this.materialListViewIncidencias);
            this.tabPage2.ImageKey = "iconoGestionarIncidencias.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incidencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabelFormatoFecha
            // 
            this.materialLabelFormatoFecha.AutoSize = true;
            this.materialLabelFormatoFecha.Depth = 0;
            this.materialLabelFormatoFecha.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelFormatoFecha.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabelFormatoFecha.Location = new System.Drawing.Point(456, 357);
            this.materialLabelFormatoFecha.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelFormatoFecha.Name = "materialLabelFormatoFecha";
            this.materialLabelFormatoFecha.Size = new System.Drawing.Size(79, 17);
            this.materialLabelFormatoFecha.TabIndex = 16;
            this.materialLabelFormatoFecha.Text = "yyyy-mm-dd";
            this.materialLabelFormatoFecha.UseAccent = true;
            // 
            // materialButtonEliminarInc
            // 
            this.materialButtonEliminarInc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonEliminarInc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonEliminarInc.Depth = 0;
            this.materialButtonEliminarInc.Enabled = false;
            this.materialButtonEliminarInc.HighEmphasis = false;
            this.materialButtonEliminarInc.Icon = null;
            this.materialButtonEliminarInc.Location = new System.Drawing.Point(629, 207);
            this.materialButtonEliminarInc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonEliminarInc.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonEliminarInc.Name = "materialButtonEliminarInc";
            this.materialButtonEliminarInc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonEliminarInc.Size = new System.Drawing.Size(88, 36);
            this.materialButtonEliminarInc.TabIndex = 8;
            this.materialButtonEliminarInc.Text = "Eliminar";
            this.materialButtonEliminarInc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonEliminarInc.UseAccentColor = false;
            this.materialButtonEliminarInc.UseVisualStyleBackColor = true;
            this.materialButtonEliminarInc.Click += new System.EventHandler(this.materialButtonEliminarInc_Click);
            // 
            // materialButtonGestionarInc
            // 
            this.materialButtonGestionarInc.AutoSize = false;
            this.materialButtonGestionarInc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGestionarInc.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGestionarInc.Depth = 0;
            this.materialButtonGestionarInc.HighEmphasis = true;
            this.materialButtonGestionarInc.Icon = null;
            this.materialButtonGestionarInc.Location = new System.Drawing.Point(13, 206);
            this.materialButtonGestionarInc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonGestionarInc.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGestionarInc.Name = "materialButtonGestionarInc";
            this.materialButtonGestionarInc.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGestionarInc.Size = new System.Drawing.Size(88, 36);
            this.materialButtonGestionarInc.TabIndex = 3;
            this.materialButtonGestionarInc.Text = "Crear";
            this.materialButtonGestionarInc.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGestionarInc.UseAccentColor = false;
            this.materialButtonGestionarInc.UseVisualStyleBackColor = true;
            this.materialButtonGestionarInc.Click += new System.EventHandler(this.materialButtonGestionarInc_Click);
            // 
            // materialTextBoxIncFechaFin
            // 
            this.materialTextBoxIncFechaFin.AnimateReadOnly = false;
            this.materialTextBoxIncFechaFin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncFechaFin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncFechaFin.Depth = 0;
            this.materialTextBoxIncFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncFechaFin.HideSelection = true;
            this.materialTextBoxIncFechaFin.Hint = "Fecha fin";
            this.materialTextBoxIncFechaFin.LeadingIcon = null;
            this.materialTextBoxIncFechaFin.Location = new System.Drawing.Point(546, 344);
            this.materialTextBoxIncFechaFin.MaxLength = 32767;
            this.materialTextBoxIncFechaFin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncFechaFin.Name = "materialTextBoxIncFechaFin";
            this.materialTextBoxIncFechaFin.PasswordChar = '\0';
            this.materialTextBoxIncFechaFin.PrefixSuffixText = null;
            this.materialTextBoxIncFechaFin.ReadOnly = false;
            this.materialTextBoxIncFechaFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncFechaFin.SelectedText = "";
            this.materialTextBoxIncFechaFin.SelectionLength = 0;
            this.materialTextBoxIncFechaFin.SelectionStart = 0;
            this.materialTextBoxIncFechaFin.ShortcutsEnabled = true;
            this.materialTextBoxIncFechaFin.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncFechaFin.TabIndex = 12;
            this.materialTextBoxIncFechaFin.TabStop = false;
            this.materialTextBoxIncFechaFin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncFechaFin.TrailingIcon = null;
            this.materialTextBoxIncFechaFin.UseSystemPasswordChar = false;
            this.materialTextBoxIncFechaFin.UseTallSize = false;
            // 
            // materialTextBoxIncLong
            // 
            this.materialTextBoxIncLong.AnimateReadOnly = false;
            this.materialTextBoxIncLong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncLong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncLong.Depth = 0;
            this.materialTextBoxIncLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncLong.HideSelection = true;
            this.materialTextBoxIncLong.Hint = "Long";
            this.materialTextBoxIncLong.LeadingIcon = null;
            this.materialTextBoxIncLong.Location = new System.Drawing.Point(13, 344);
            this.materialTextBoxIncLong.MaxLength = 32767;
            this.materialTextBoxIncLong.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncLong.Name = "materialTextBoxIncLong";
            this.materialTextBoxIncLong.PasswordChar = '\0';
            this.materialTextBoxIncLong.PrefixSuffixText = null;
            this.materialTextBoxIncLong.ReadOnly = false;
            this.materialTextBoxIncLong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncLong.SelectedText = "";
            this.materialTextBoxIncLong.SelectionLength = 0;
            this.materialTextBoxIncLong.SelectionStart = 0;
            this.materialTextBoxIncLong.ShortcutsEnabled = true;
            this.materialTextBoxIncLong.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncLong.TabIndex = 11;
            this.materialTextBoxIncLong.TabStop = false;
            this.materialTextBoxIncLong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncLong.TrailingIcon = null;
            this.materialTextBoxIncLong.UseSystemPasswordChar = false;
            this.materialTextBoxIncLong.UseTallSize = false;
            // 
            // materialTextBoxIncFechaInicio
            // 
            this.materialTextBoxIncFechaInicio.AnimateReadOnly = false;
            this.materialTextBoxIncFechaInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncFechaInicio.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncFechaInicio.Depth = 0;
            this.materialTextBoxIncFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncFechaInicio.HideSelection = true;
            this.materialTextBoxIncFechaInicio.Hint = "Fecha inicio";
            this.materialTextBoxIncFechaInicio.LeadingIcon = null;
            this.materialTextBoxIncFechaInicio.Location = new System.Drawing.Point(277, 344);
            this.materialTextBoxIncFechaInicio.MaxLength = 32767;
            this.materialTextBoxIncFechaInicio.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncFechaInicio.Name = "materialTextBoxIncFechaInicio";
            this.materialTextBoxIncFechaInicio.PasswordChar = '\0';
            this.materialTextBoxIncFechaInicio.PrefixSuffixText = null;
            this.materialTextBoxIncFechaInicio.ReadOnly = false;
            this.materialTextBoxIncFechaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncFechaInicio.SelectedText = "";
            this.materialTextBoxIncFechaInicio.SelectionLength = 0;
            this.materialTextBoxIncFechaInicio.SelectionStart = 0;
            this.materialTextBoxIncFechaInicio.ShortcutsEnabled = true;
            this.materialTextBoxIncFechaInicio.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncFechaInicio.TabIndex = 10;
            this.materialTextBoxIncFechaInicio.TabStop = false;
            this.materialTextBoxIncFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncFechaInicio.TrailingIcon = null;
            this.materialTextBoxIncFechaInicio.UseSystemPasswordChar = false;
            this.materialTextBoxIncFechaInicio.UseTallSize = false;
            // 
            // materialComboBoxIncSource
            // 
            this.materialComboBoxIncSource.AutoResize = false;
            this.materialComboBoxIncSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxIncSource.Depth = 0;
            this.materialComboBoxIncSource.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxIncSource.DropDownHeight = 118;
            this.materialComboBoxIncSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxIncSource.DropDownWidth = 121;
            this.materialComboBoxIncSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxIncSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxIncSource.FormattingEnabled = true;
            this.materialComboBoxIncSource.IntegralHeight = false;
            this.materialComboBoxIncSource.ItemHeight = 29;
            this.materialComboBoxIncSource.Location = new System.Drawing.Point(431, 207);
            this.materialComboBoxIncSource.MaxDropDownItems = 4;
            this.materialComboBoxIncSource.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxIncSource.Name = "materialComboBoxIncSource";
            this.materialComboBoxIncSource.Size = new System.Drawing.Size(140, 35);
            this.materialComboBoxIncSource.StartIndex = 1;
            this.materialComboBoxIncSource.TabIndex = 9;
            this.materialComboBoxIncSource.UseTallSize = false;
            // 
            // materialTextBoxIncLat
            // 
            this.materialTextBoxIncLat.AnimateReadOnly = false;
            this.materialTextBoxIncLat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncLat.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncLat.Depth = 0;
            this.materialTextBoxIncLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncLat.HideSelection = true;
            this.materialTextBoxIncLat.Hint = "Latitud";
            this.materialTextBoxIncLat.LeadingIcon = null;
            this.materialTextBoxIncLat.Location = new System.Drawing.Point(546, 301);
            this.materialTextBoxIncLat.MaxLength = 32767;
            this.materialTextBoxIncLat.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncLat.Name = "materialTextBoxIncLat";
            this.materialTextBoxIncLat.PasswordChar = '\0';
            this.materialTextBoxIncLat.PrefixSuffixText = null;
            this.materialTextBoxIncLat.ReadOnly = false;
            this.materialTextBoxIncLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncLat.SelectedText = "";
            this.materialTextBoxIncLat.SelectionLength = 0;
            this.materialTextBoxIncLat.SelectionStart = 0;
            this.materialTextBoxIncLat.ShortcutsEnabled = true;
            this.materialTextBoxIncLat.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncLat.TabIndex = 8;
            this.materialTextBoxIncLat.TabStop = false;
            this.materialTextBoxIncLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncLat.TrailingIcon = null;
            this.materialTextBoxIncLat.UseSystemPasswordChar = false;
            this.materialTextBoxIncLat.UseTallSize = false;
            // 
            // materialTextBoxIncTipo
            // 
            this.materialTextBoxIncTipo.AnimateReadOnly = false;
            this.materialTextBoxIncTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncTipo.Depth = 0;
            this.materialTextBoxIncTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncTipo.HideSelection = true;
            this.materialTextBoxIncTipo.Hint = "Tipo";
            this.materialTextBoxIncTipo.LeadingIcon = null;
            this.materialTextBoxIncTipo.Location = new System.Drawing.Point(13, 301);
            this.materialTextBoxIncTipo.MaxLength = 32767;
            this.materialTextBoxIncTipo.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncTipo.Name = "materialTextBoxIncTipo";
            this.materialTextBoxIncTipo.PasswordChar = '\0';
            this.materialTextBoxIncTipo.PrefixSuffixText = null;
            this.materialTextBoxIncTipo.ReadOnly = false;
            this.materialTextBoxIncTipo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncTipo.SelectedText = "";
            this.materialTextBoxIncTipo.SelectionLength = 0;
            this.materialTextBoxIncTipo.SelectionStart = 0;
            this.materialTextBoxIncTipo.ShortcutsEnabled = true;
            this.materialTextBoxIncTipo.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncTipo.TabIndex = 7;
            this.materialTextBoxIncTipo.TabStop = false;
            this.materialTextBoxIncTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncTipo.TrailingIcon = null;
            this.materialTextBoxIncTipo.UseSystemPasswordChar = false;
            this.materialTextBoxIncTipo.UseTallSize = false;
            // 
            // materialTextBoxIncProvincia
            // 
            this.materialTextBoxIncProvincia.AnimateReadOnly = false;
            this.materialTextBoxIncProvincia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncProvincia.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncProvincia.Depth = 0;
            this.materialTextBoxIncProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncProvincia.HideSelection = true;
            this.materialTextBoxIncProvincia.Hint = "Provincia";
            this.materialTextBoxIncProvincia.LeadingIcon = null;
            this.materialTextBoxIncProvincia.Location = new System.Drawing.Point(277, 301);
            this.materialTextBoxIncProvincia.MaxLength = 32767;
            this.materialTextBoxIncProvincia.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncProvincia.Name = "materialTextBoxIncProvincia";
            this.materialTextBoxIncProvincia.PasswordChar = '\0';
            this.materialTextBoxIncProvincia.PrefixSuffixText = null;
            this.materialTextBoxIncProvincia.ReadOnly = false;
            this.materialTextBoxIncProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncProvincia.SelectedText = "";
            this.materialTextBoxIncProvincia.SelectionLength = 0;
            this.materialTextBoxIncProvincia.SelectionStart = 0;
            this.materialTextBoxIncProvincia.ShortcutsEnabled = true;
            this.materialTextBoxIncProvincia.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncProvincia.TabIndex = 6;
            this.materialTextBoxIncProvincia.TabStop = false;
            this.materialTextBoxIncProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncProvincia.TrailingIcon = null;
            this.materialTextBoxIncProvincia.UseSystemPasswordChar = false;
            this.materialTextBoxIncProvincia.UseTallSize = false;
            // 
            // materialTextBoxIncCausa
            // 
            this.materialTextBoxIncCausa.AnimateReadOnly = false;
            this.materialTextBoxIncCausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncCausa.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncCausa.Depth = 0;
            this.materialTextBoxIncCausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncCausa.HideSelection = true;
            this.materialTextBoxIncCausa.Hint = "Causa";
            this.materialTextBoxIncCausa.LeadingIcon = null;
            this.materialTextBoxIncCausa.Location = new System.Drawing.Point(546, 257);
            this.materialTextBoxIncCausa.MaxLength = 32767;
            this.materialTextBoxIncCausa.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncCausa.Name = "materialTextBoxIncCausa";
            this.materialTextBoxIncCausa.PasswordChar = '\0';
            this.materialTextBoxIncCausa.PrefixSuffixText = null;
            this.materialTextBoxIncCausa.ReadOnly = false;
            this.materialTextBoxIncCausa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncCausa.SelectedText = "";
            this.materialTextBoxIncCausa.SelectionLength = 0;
            this.materialTextBoxIncCausa.SelectionStart = 0;
            this.materialTextBoxIncCausa.ShortcutsEnabled = true;
            this.materialTextBoxIncCausa.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncCausa.TabIndex = 4;
            this.materialTextBoxIncCausa.TabStop = false;
            this.materialTextBoxIncCausa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncCausa.TrailingIcon = null;
            this.materialTextBoxIncCausa.UseSystemPasswordChar = false;
            this.materialTextBoxIncCausa.UseTallSize = false;
            // 
            // materialTextBoxIncReg
            // 
            this.materialTextBoxIncReg.AnimateReadOnly = false;
            this.materialTextBoxIncReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncReg.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncReg.Depth = 0;
            this.materialTextBoxIncReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncReg.HideSelection = true;
            this.materialTextBoxIncReg.Hint = "Región autónoma";
            this.materialTextBoxIncReg.LeadingIcon = null;
            this.materialTextBoxIncReg.Location = new System.Drawing.Point(13, 257);
            this.materialTextBoxIncReg.MaxLength = 32767;
            this.materialTextBoxIncReg.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncReg.Name = "materialTextBoxIncReg";
            this.materialTextBoxIncReg.PasswordChar = '\0';
            this.materialTextBoxIncReg.PrefixSuffixText = null;
            this.materialTextBoxIncReg.ReadOnly = false;
            this.materialTextBoxIncReg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncReg.SelectedText = "";
            this.materialTextBoxIncReg.SelectionLength = 0;
            this.materialTextBoxIncReg.SelectionStart = 0;
            this.materialTextBoxIncReg.ShortcutsEnabled = true;
            this.materialTextBoxIncReg.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncReg.TabIndex = 3;
            this.materialTextBoxIncReg.TabStop = false;
            this.materialTextBoxIncReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncReg.TrailingIcon = null;
            this.materialTextBoxIncReg.UseSystemPasswordChar = false;
            this.materialTextBoxIncReg.UseTallSize = false;
            // 
            // materialTextBoxIncCiudad
            // 
            this.materialTextBoxIncCiudad.AnimateReadOnly = false;
            this.materialTextBoxIncCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncCiudad.Depth = 0;
            this.materialTextBoxIncCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncCiudad.HideSelection = true;
            this.materialTextBoxIncCiudad.Hint = "Ciudad";
            this.materialTextBoxIncCiudad.LeadingIcon = null;
            this.materialTextBoxIncCiudad.Location = new System.Drawing.Point(277, 257);
            this.materialTextBoxIncCiudad.MaxLength = 32767;
            this.materialTextBoxIncCiudad.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncCiudad.Name = "materialTextBoxIncCiudad";
            this.materialTextBoxIncCiudad.PasswordChar = '\0';
            this.materialTextBoxIncCiudad.PrefixSuffixText = null;
            this.materialTextBoxIncCiudad.ReadOnly = false;
            this.materialTextBoxIncCiudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncCiudad.SelectedText = "";
            this.materialTextBoxIncCiudad.SelectionLength = 0;
            this.materialTextBoxIncCiudad.SelectionStart = 0;
            this.materialTextBoxIncCiudad.ShortcutsEnabled = true;
            this.materialTextBoxIncCiudad.Size = new System.Drawing.Size(171, 36);
            this.materialTextBoxIncCiudad.TabIndex = 2;
            this.materialTextBoxIncCiudad.TabStop = false;
            this.materialTextBoxIncCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncCiudad.TrailingIcon = null;
            this.materialTextBoxIncCiudad.UseSystemPasswordChar = false;
            this.materialTextBoxIncCiudad.UseTallSize = false;
            // 
            // materialTextBoxIncId
            // 
            this.materialTextBoxIncId.AnimateReadOnly = false;
            this.materialTextBoxIncId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxIncId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxIncId.Depth = 0;
            this.materialTextBoxIncId.Enabled = false;
            this.materialTextBoxIncId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxIncId.HideSelection = true;
            this.materialTextBoxIncId.Hint = "ID";
            this.materialTextBoxIncId.LeadingIcon = null;
            this.materialTextBoxIncId.Location = new System.Drawing.Point(162, 206);
            this.materialTextBoxIncId.MaxLength = 32767;
            this.materialTextBoxIncId.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxIncId.Name = "materialTextBoxIncId";
            this.materialTextBoxIncId.PasswordChar = '\0';
            this.materialTextBoxIncId.PrefixSuffixText = null;
            this.materialTextBoxIncId.ReadOnly = false;
            this.materialTextBoxIncId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxIncId.SelectedText = "";
            this.materialTextBoxIncId.SelectionLength = 0;
            this.materialTextBoxIncId.SelectionStart = 0;
            this.materialTextBoxIncId.ShortcutsEnabled = true;
            this.materialTextBoxIncId.Size = new System.Drawing.Size(140, 36);
            this.materialTextBoxIncId.TabIndex = 1;
            this.materialTextBoxIncId.TabStop = false;
            this.materialTextBoxIncId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxIncId.TrailingIcon = null;
            this.materialTextBoxIncId.UseSystemPasswordChar = false;
            this.materialTextBoxIncId.UseTallSize = false;
            // 
            // avisoIncEliminada
            // 
            this.avisoIncEliminada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoIncEliminada.Location = new System.Drawing.Point(837, 9);
            this.avisoIncEliminada.Name = "avisoIncEliminada";
            this.avisoIncEliminada.Size = new System.Drawing.Size(259, 66);
            this.avisoIncEliminada.TabIndex = 15;
            // 
            // avisoIncModificada
            // 
            this.avisoIncModificada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoIncModificada.Location = new System.Drawing.Point(833, 9);
            this.avisoIncModificada.Name = "avisoIncModificada";
            this.avisoIncModificada.Size = new System.Drawing.Size(278, 66);
            this.avisoIncModificada.TabIndex = 14;
            // 
            // avisoIncCreada
            // 
            this.avisoIncCreada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoIncCreada.Location = new System.Drawing.Point(796, 9);
            this.avisoIncCreada.Name = "avisoIncCreada";
            this.avisoIncCreada.Size = new System.Drawing.Size(238, 66);
            this.avisoIncCreada.TabIndex = 13;
            // 
            // materialListViewIncidencias
            // 
            this.materialListViewIncidencias.AutoSizeTable = false;
            this.materialListViewIncidencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListViewIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListViewIncidencias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIncId,
            this.columnIncAutonomousRegion,
            this.columnIncCityTown,
            this.columnIncCause,
            this.columnIncIncidendeType,
            this.columnIncProvince,
            this.columnIncLat,
            this.columnIncLong,
            this.columnStartDate,
            this.columnEndDate,
            this.columnIncSourceId});
            this.materialListViewIncidencias.Depth = 0;
            this.materialListViewIncidencias.FullRowSelect = true;
            this.materialListViewIncidencias.HideSelection = false;
            this.materialListViewIncidencias.Location = new System.Drawing.Point(6, 6);
            this.materialListViewIncidencias.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListViewIncidencias.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListViewIncidencias.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListViewIncidencias.Name = "materialListViewIncidencias";
            this.materialListViewIncidencias.OwnerDraw = true;
            this.materialListViewIncidencias.Size = new System.Drawing.Size(777, 188);
            this.materialListViewIncidencias.TabIndex = 0;
            this.materialListViewIncidencias.UseCompatibleStateImageBehavior = false;
            this.materialListViewIncidencias.View = System.Windows.Forms.View.Details;
            this.materialListViewIncidencias.SelectedIndexChanged += new System.EventHandler(this.materialListViewIncidencias_SelectedIndexChanged);
            // 
            // columnIncId
            // 
            this.columnIncId.Text = "ID";
            this.columnIncId.Width = 45;
            // 
            // columnIncAutonomousRegion
            // 
            this.columnIncAutonomousRegion.Text = "Región a.";
            this.columnIncAutonomousRegion.Width = 92;
            // 
            // columnIncCityTown
            // 
            this.columnIncCityTown.Text = "Ciudad";
            this.columnIncCityTown.Width = 80;
            // 
            // columnIncCause
            // 
            this.columnIncCause.Text = "Causa";
            this.columnIncCause.Width = 72;
            // 
            // columnIncIncidendeType
            // 
            this.columnIncIncidendeType.Text = "Tipo inc.";
            this.columnIncIncidendeType.Width = 89;
            // 
            // columnIncProvince
            // 
            this.columnIncProvince.Text = "Provincia";
            this.columnIncProvince.Width = 100;
            // 
            // columnIncLat
            // 
            this.columnIncLat.Text = "Lat";
            this.columnIncLat.Width = 53;
            // 
            // columnIncLong
            // 
            this.columnIncLong.Text = "Long";
            this.columnIncLong.Width = 64;
            // 
            // columnStartDate
            // 
            this.columnStartDate.Text = "Fecha I.";
            this.columnStartDate.Width = 81;
            // 
            // columnEndDate
            // 
            this.columnEndDate.Text = "Fecha F.";
            this.columnEndDate.Width = 86;
            // 
            // columnIncSourceId
            // 
            this.columnIncSourceId.Text = "Source";
            this.columnIncSourceId.Width = 130;
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "iconoGestionarIncidencias.png");
            this.iconos.Images.SetKeyName(1, "iconoGestionUsuarios.png");
            // 
            // buttomLogOut
            // 
            this.buttomLogOut.BackColor = System.Drawing.Color.Transparent;
            this.buttomLogOut.BackgroundImage = global::AppEscritorioReto_PabloAimarChristian.Properties.Resources.logoutIcono;
            this.buttomLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttomLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttomLogOut.FlatAppearance.BorderSize = 0;
            this.buttomLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttomLogOut.Location = new System.Drawing.Point(757, 24);
            this.buttomLogOut.Name = "buttomLogOut";
            this.buttomLogOut.Size = new System.Drawing.Size(40, 40);
            this.buttomLogOut.TabIndex = 2;
            this.buttomLogOut.UseVisualStyleBackColor = false;
            this.buttomLogOut.Click += new System.EventHandler(this.buttomLogOut_Click);
            // 
            // loginComponente1
            // 
            this.loginComponente1.BackColor = System.Drawing.Color.Transparent;
            this.loginComponente1.Location = new System.Drawing.Point(466, 13);
            this.loginComponente1.Name = "loginComponente1";
            this.loginComponente1.Size = new System.Drawing.Size(284, 50);
            this.loginComponente1.TabIndex = 1;
            // 
            // buttonAbrirMapa
            // 
            this.buttonAbrirMapa.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbrirMapa.BackgroundImage = global::AppEscritorioReto_PabloAimarChristian.Properties.Resources.logoutIcono;
            this.buttonAbrirMapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAbrirMapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbrirMapa.FlatAppearance.BorderSize = 0;
            this.buttonAbrirMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirMapa.Location = new System.Drawing.Point(473, 297);
            this.buttonAbrirMapa.Name = "buttonAbrirMapa";
            this.buttonAbrirMapa.Size = new System.Drawing.Size(40, 40);
            this.buttonAbrirMapa.TabIndex = 3;
            this.buttonAbrirMapa.UseVisualStyleBackColor = false;
            this.buttonAbrirMapa.Click += new System.EventHandler(this.buttonAbrirMapa_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttomLogOut);
            this.Controls.Add(this.loginComponente1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Gestion";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Sizable = false;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList iconos;
        private MaterialSkin.Controls.MaterialButton materialButtonGestionUsuarios;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxUsuario;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxAdmin;
        private MaterialSkin.Controls.MaterialListView materialListViewUsuarios;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnAdmin;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxId;
        private AppEscritorioRetoDAM.LoginComponente loginComponente1;
        private MaterialSkin.Controls.MaterialButton materialButtonEliminarUsuario;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPassword;
        private AppEscritorioRetoDAM.AvisoUsuarioModificado avisoUsuarioModificado;
        private AppEscritorioRetoDAM.AvisoUsuarioCreado avisoUsuarioCreado;
        private AppEscritorioRetoDAM.UsuarioEliminado avisoUsuarioEliminado;
        private System.Windows.Forms.Label labelUsuarioDuplicado;
        private System.Windows.Forms.Button buttomLogOut;
        private MaterialSkin.Controls.MaterialListView materialListViewIncidencias;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncId;
        private System.Windows.Forms.ColumnHeader columnIncId;
        private System.Windows.Forms.ColumnHeader columnIncAutonomousRegion;
        private System.Windows.Forms.ColumnHeader columnIncCityTown;
        private System.Windows.Forms.ColumnHeader columnIncCause;
        private System.Windows.Forms.ColumnHeader columnIncIncidendeType;
        private System.Windows.Forms.ColumnHeader columnIncProvince;
        private System.Windows.Forms.ColumnHeader columnIncLat;
        private System.Windows.Forms.ColumnHeader columnIncLong;
        private System.Windows.Forms.ColumnHeader columnStartDate;
        private System.Windows.Forms.ColumnHeader columnEndDate;
        private System.Windows.Forms.ColumnHeader columnIncSourceId;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncCiudad;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncReg;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncCausa;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncLat;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncTipo;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncProvincia;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxIncSource;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncFechaFin;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncLong;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxIncFechaInicio;
        private MaterialSkin.Controls.MaterialButton materialButtonGestionarInc;
        private MaterialSkin.Controls.MaterialButton materialButtonEliminarInc;
        private AppEscritorioRetoDAM.AvisoIncCreada avisoIncCreada;
        private AppEscritorioRetoDAM.AvisoIncModificada avisoIncModificada;
        private AppEscritorioRetoDAM.AvisoIncEliminada avisoIncEliminada;
        private MaterialSkin.Controls.MaterialLabel materialLabelFormatoFecha;
        private System.Windows.Forms.Button buttonAbrirMapa;
    }
}