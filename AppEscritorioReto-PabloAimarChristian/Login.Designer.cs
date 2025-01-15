namespace AppEscritorioReto_PabloAimarChristian
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.inputContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAcceder = new MaterialSkin.Controls.MaterialButton();
            this.labelErrorLogin = new System.Windows.Forms.Label();
            this.loginComponente1 = new AppEscritorioRetoDAM.LoginComponente();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inputUsuario
            // 
            this.inputUsuario.AnimateReadOnly = false;
            this.inputUsuario.BackColor = System.Drawing.Color.LimeGreen;
            this.inputUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputUsuario.Depth = 0;
            this.inputUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputUsuario.Hint = "Usuario";
            this.inputUsuario.LeadingIcon = null;
            this.inputUsuario.Location = new System.Drawing.Point(502, 198);
            this.inputUsuario.MaxLength = 50;
            this.inputUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.inputUsuario.Multiline = false;
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(216, 36);
            this.inputUsuario.TabIndex = 1;
            this.inputUsuario.Text = "";
            this.inputUsuario.TrailingIcon = null;
            this.inputUsuario.UseTallSize = false;
            // 
            // inputContrasena
            // 
            this.inputContrasena.AnimateReadOnly = false;
            this.inputContrasena.BackColor = System.Drawing.Color.LimeGreen;
            this.inputContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputContrasena.Depth = 0;
            this.inputContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.inputContrasena.Hint = "Contraseña";
            this.inputContrasena.LeadingIcon = null;
            this.inputContrasena.Location = new System.Drawing.Point(502, 257);
            this.inputContrasena.MaxLength = 50;
            this.inputContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.inputContrasena.Multiline = false;
            this.inputContrasena.Name = "inputContrasena";
            this.inputContrasena.Password = true;
            this.inputContrasena.Size = new System.Drawing.Size(216, 36);
            this.inputContrasena.TabIndex = 3;
            this.inputContrasena.Text = "";
            this.inputContrasena.TrailingIcon = null;
            this.inputContrasena.UseTallSize = false;
            // 
            // btnAcceder
            // 
            this.btnAcceder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAcceder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnAcceder.Depth = 0;
            this.btnAcceder.HighEmphasis = true;
            this.btnAcceder.Icon = null;
            this.btnAcceder.Location = new System.Drawing.Point(562, 328);
            this.btnAcceder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAcceder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAcceder.Size = new System.Drawing.Size(86, 36);
            this.btnAcceder.TabIndex = 4;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAcceder.UseAccentColor = false;
            this.btnAcceder.UseVisualStyleBackColor = true;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // labelErrorLogin
            // 
            this.labelErrorLogin.AutoSize = true;
            this.labelErrorLogin.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.labelErrorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelErrorLogin.Location = new System.Drawing.Point(503, 159);
            this.labelErrorLogin.Name = "labelErrorLogin";
            this.labelErrorLogin.Size = new System.Drawing.Size(0, 19);
            this.labelErrorLogin.TabIndex = 6;
            // 
            // loginComponente1
            // 
            this.loginComponente1.BackColor = System.Drawing.Color.Transparent;
            this.loginComponente1.Location = new System.Drawing.Point(465, 89);
            this.loginComponente1.Name = "loginComponente1";
            this.loginComponente1.Size = new System.Drawing.Size(284, 67);
            this.loginComponente1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppEscritorioReto_PabloAimarChristian.Properties.Resources.fondoLogin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-49, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 459);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.inputContrasena);
            this.Controls.Add(this.loginComponente1);
            this.Controls.Add(this.inputUsuario);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AppEscritorioRetoDAM.LoginComponente loginComponente1;
        private MaterialSkin.Controls.MaterialTextBox inputUsuario;
        private MaterialSkin.Controls.MaterialTextBox inputContrasena;
        private MaterialSkin.Controls.MaterialButton btnAcceder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelErrorLogin;
    }
}

