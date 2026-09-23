namespace GHSistemaDeInventario
{
    partial class Inicio_Sesion
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
            btn_login = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            Contrasenia = new Label();
            usuario = new Label();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(354, 266);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 9;
            btn_login.Text = "Inicio";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(312, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 8;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(312, 179);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(177, 23);
            txtUsuario.TabIndex = 7;
            // 
            // Contrasenia
            // 
            Contrasenia.AutoSize = true;
            Contrasenia.Location = new Point(312, 210);
            Contrasenia.Name = "Contrasenia";
            Contrasenia.Size = new Size(67, 15);
            Contrasenia.TabIndex = 6;
            Contrasenia.Text = "Contraseña";
            // 
            // usuario
            // 
            usuario.AutoSize = true;
            usuario.Location = new Point(312, 161);
            usuario.MaximumSize = new Size(200, 300);
            usuario.Name = "usuario";
            usuario.Size = new Size(47, 15);
            usuario.TabIndex = 5;
            usuario.Text = "Usuario";
            // 
            // Inicio_Sesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(Contrasenia);
            Controls.Add(usuario);
            Name = "Inicio_Sesion";
            Text = "Inicio_Sesion";
            Load += Inicio_Sesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Label Contrasenia;
        private Label usuario;
    }
}