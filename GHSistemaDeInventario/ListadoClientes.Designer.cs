namespace GHSistemaDeInventario
{
    partial class ListadoClientes
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
            dgvClientes = new DataGridView();
            progressBarCarga = new ProgressBar();
            lblCargando = new Label();
            agregar_clientes_nuevos = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(21, 12);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.Size = new Size(1232, 442);
            dgvClientes.TabIndex = 0;
            // 
            // progressBarCarga
            // 
            progressBarCarga.Location = new Point(578, 211);
            progressBarCarga.Name = "progressBarCarga";
            progressBarCarga.Size = new Size(100, 23);
            progressBarCarga.Style = ProgressBarStyle.Marquee;
            progressBarCarga.TabIndex = 1;
            progressBarCarga.Visible = false;
            // 
            // lblCargando
            // 
            lblCargando.AutoSize = true;
            lblCargando.Location = new Point(535, 193);
            lblCargando.Name = "lblCargando";
            lblCargando.Size = new Size(191, 15);
            lblCargando.TabIndex = 2;
            lblCargando.Text = "Cargando datos, por favor espere...";
            lblCargando.Visible = false;
            // 
            // agregar_clientes_nuevos
            // 
            agregar_clientes_nuevos.BackColor = SystemColors.MenuBar;
            agregar_clientes_nuevos.Cursor = Cursors.Hand;
            agregar_clientes_nuevos.ForeColor = SystemColors.ActiveCaptionText;
            agregar_clientes_nuevos.Location = new Point(749, 559);
            agregar_clientes_nuevos.Name = "agregar_clientes_nuevos";
            agregar_clientes_nuevos.Size = new Size(116, 23);
            agregar_clientes_nuevos.TabIndex = 3;
            agregar_clientes_nuevos.Text = "Agregar";
            agregar_clientes_nuevos.UseVisualStyleBackColor = false;
            agregar_clientes_nuevos.Click += agregar_clientes_nuevos_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(912, 559);
            button2.Name = "button2";
            button2.Size = new Size(116, 23);
            button2.TabIndex = 4;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLightLight;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1070, 559);
            button3.Name = "button3";
            button3.Size = new Size(116, 23);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = false;
            // 
            // ListadoClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 690);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(agregar_clientes_nuevos);
            Controls.Add(lblCargando);
            Controls.Add(progressBarCarga);
            Controls.Add(dgvClientes);
            Name = "ListadoClientes";
            Text = "ListadoClientes";
            Load += ListadoClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private ProgressBar progressBarCarga;
        private Label lblCargando;
        private Button agregar_clientes_nuevos;
        private Button button2;
        private Button button3;
    }
}