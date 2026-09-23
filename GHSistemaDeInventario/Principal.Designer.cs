namespace GHSistemaDeInventario
{
    partial class Principal
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
            btn_clientes = new Button();
            btn_productos = new Button();
            btn_salida = new Button();
            SuspendLayout();
            // 
            // btn_clientes
            // 
            btn_clientes.Location = new Point(339, 124);
            btn_clientes.Name = "btn_clientes";
            btn_clientes.Size = new Size(92, 30);
            btn_clientes.TabIndex = 0;
            btn_clientes.Text = "Clientes";
            btn_clientes.UseVisualStyleBackColor = true;
            btn_clientes.Click += btn_clientes_Click;
            // 
            // btn_productos
            // 
            btn_productos.Location = new Point(339, 179);
            btn_productos.Name = "btn_productos";
            btn_productos.Size = new Size(92, 30);
            btn_productos.TabIndex = 1;
            btn_productos.Text = "Productos";
            btn_productos.UseVisualStyleBackColor = true;
            // 
            // btn_salida
            // 
            btn_salida.Location = new Point(339, 238);
            btn_salida.Name = "btn_salida";
            btn_salida.Size = new Size(92, 30);
            btn_salida.TabIndex = 2;
            btn_salida.Text = "Salir";
            btn_salida.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_salida);
            Controls.Add(btn_productos);
            Controls.Add(btn_clientes);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_clientes;
        private Button btn_productos;
        private Button btn_salida;
    }
}