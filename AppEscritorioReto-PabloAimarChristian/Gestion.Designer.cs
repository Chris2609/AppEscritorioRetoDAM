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
            this.iconos = new System.Windows.Forms.ImageList(this.components);
            this.loginComponente1 = new AppEscritorioRetoDAM.LoginComponente();
            this.avisoUsuarioCreado = new AppEscritorioRetoDAM.AvisoUsuarioCreado();
            this.avisoUsuarioModificado = new AppEscritorioRetoDAM.AvisoUsuarioModificado();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.Hint = "Contraseña";
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(376, 170);
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
            this.materialButtonEliminarUsuario.Location = new System.Drawing.Point(509, 297);
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
            this.materialTextBoxId.Location = new System.Drawing.Point(376, 39);
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
            this.materialListViewUsuarios.Size = new System.Drawing.Size(278, 379);
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
            this.columnNombre.Width = 121;
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
            this.materialCheckboxAdmin.Location = new System.Drawing.Point(436, 230);
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
            this.materialTextBoxUsuario.Location = new System.Drawing.Point(376, 98);
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
            this.materialButtonGestionUsuarios.Location = new System.Drawing.Point(376, 297);
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
            this.tabPage2.ImageKey = "iconoGestionarIncidencias.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Incidencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iconos
            // 
            this.iconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconos.ImageStream")));
            this.iconos.TransparentColor = System.Drawing.Color.Transparent;
            this.iconos.Images.SetKeyName(0, "iconoGestionarIncidencias.png");
            this.iconos.Images.SetKeyName(1, "iconoGestionUsuarios.png");
            // 
            // loginComponente1
            // 
            this.loginComponente1.BackColor = System.Drawing.Color.Transparent;
            this.loginComponente1.Location = new System.Drawing.Point(466, 13);
            this.loginComponente1.Name = "loginComponente1";
            this.loginComponente1.Size = new System.Drawing.Size(284, 50);
            this.loginComponente1.TabIndex = 1;
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
            // avisoUsuarioModificado
            // 
            this.avisoUsuarioModificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.avisoUsuarioModificado.Location = new System.Drawing.Point(796, 9);
            this.avisoUsuarioModificado.Name = "avisoUsuarioModificado";
            this.avisoUsuarioModificado.Size = new System.Drawing.Size(278, 66);
            this.avisoUsuarioModificado.TabIndex = 11;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}