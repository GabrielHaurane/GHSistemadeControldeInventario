using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GHSistemaDeInventario
{
    partial class AgregarClientes
    {
        private IContainer components = null;

        private TableLayoutPanel tableLayoutPanel;
        private Label lblRazonSocial;
        private TextBox txtRazonSocial;
        private Label lblCuitCuil;
        private TextBox txtCuitCuil;
        private Label lblMail;
        private TextBox txtMail;
        private Label lblCodigoArea;
        private TextBox txtCodigoArea;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblLimiteCredito;
        private TextBox txtLimiteCredito;
        private Label lblCanalLista;
        private ComboBox cmbCanalLista;
        private FlowLayoutPanel flowButtons;
        private Button btnGuardar;
        private Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            lblRazonSocial = new Label();
            txtRazonSocial = new TextBox();
            lblCuitCuil = new Label();
            txtCuitCuil = new TextBox();
            lblMail = new Label();
            txtMail = new TextBox();
            lblCodigoArea = new Label();
            txtCodigoArea = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblLimiteCredito = new Label();
            txtLimiteCredito = new TextBox();
            lblCanalLista = new Label();
            cmbCanalLista = new ComboBox();
            flowButtons = new FlowLayoutPanel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            tableLayoutPanel.SuspendLayout();
            flowButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.3142F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.6858F));
            tableLayoutPanel.Controls.Add(lblRazonSocial, 0, 0);
            tableLayoutPanel.Controls.Add(txtRazonSocial, 1, 0);
            tableLayoutPanel.Controls.Add(lblCuitCuil, 0, 1);
            tableLayoutPanel.Controls.Add(txtCuitCuil, 1, 1);
            tableLayoutPanel.Controls.Add(lblMail, 0, 2);
            tableLayoutPanel.Controls.Add(txtMail, 1, 2);
            tableLayoutPanel.Controls.Add(lblCodigoArea, 0, 3);
            tableLayoutPanel.Controls.Add(txtCodigoArea, 1, 3);
            tableLayoutPanel.Controls.Add(lblTelefono, 0, 4);
            tableLayoutPanel.Controls.Add(txtTelefono, 1, 4);
            tableLayoutPanel.Controls.Add(lblDireccion, 0, 5);
            tableLayoutPanel.Controls.Add(txtDireccion, 1, 5);
            tableLayoutPanel.Controls.Add(lblLimiteCredito, 0, 6);
            tableLayoutPanel.Controls.Add(txtLimiteCredito, 1, 6);
            tableLayoutPanel.Controls.Add(lblCanalLista, 0, 7);
            tableLayoutPanel.Controls.Add(cmbCanalLista, 1, 7);
            tableLayoutPanel.Location = new Point(6, 9);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(12);
            tableLayoutPanel.RowCount = 8;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel.Size = new Size(1348, 304);
            tableLayoutPanel.TabIndex = 0;
            // 
            // lblRazonSocial
            // 
            lblRazonSocial.Dock = DockStyle.Fill;
            lblRazonSocial.Font = new Font("Segoe UI", 9F);
            lblRazonSocial.Location = new Point(15, 12);
            lblRazonSocial.Name = "lblRazonSocial";
            lblRazonSocial.Padding = new Padding(6, 0, 0, 0);
            lblRazonSocial.Size = new Size(210, 36);
            lblRazonSocial.TabIndex = 0;
            lblRazonSocial.Text = "Razón social:";
            lblRazonSocial.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRazonSocial
            // 
            txtRazonSocial.Dock = DockStyle.Fill;
            txtRazonSocial.Font = new Font("Segoe UI", 9F);
            txtRazonSocial.Location = new Point(231, 15);
            txtRazonSocial.Name = "txtRazonSocial";
            txtRazonSocial.Size = new Size(1102, 23);
            txtRazonSocial.TabIndex = 1;
            // 
            // lblCuitCuil
            // 
            lblCuitCuil.Dock = DockStyle.Fill;
            lblCuitCuil.Font = new Font("Segoe UI", 9F);
            lblCuitCuil.Location = new Point(15, 48);
            lblCuitCuil.Name = "lblCuitCuil";
            lblCuitCuil.Padding = new Padding(6, 0, 0, 0);
            lblCuitCuil.Size = new Size(210, 36);
            lblCuitCuil.TabIndex = 2;
            lblCuitCuil.Text = "CUIT / CUIL:";
            lblCuitCuil.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCuitCuil
            // 
            txtCuitCuil.Dock = DockStyle.Fill;
            txtCuitCuil.Font = new Font("Segoe UI", 9F);
            txtCuitCuil.Location = new Point(231, 51);
            txtCuitCuil.Name = "txtCuitCuil";
            txtCuitCuil.Size = new Size(1102, 23);
            txtCuitCuil.TabIndex = 3;
            // 
            // lblMail
            // 
            lblMail.Dock = DockStyle.Fill;
            lblMail.Font = new Font("Segoe UI", 9F);
            lblMail.Location = new Point(15, 84);
            lblMail.Name = "lblMail";
            lblMail.Padding = new Padding(6, 0, 0, 0);
            lblMail.Size = new Size(210, 36);
            lblMail.TabIndex = 4;
            lblMail.Text = "Mail:";
            lblMail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMail
            // 
            txtMail.Dock = DockStyle.Fill;
            txtMail.Font = new Font("Segoe UI", 9F);
            txtMail.Location = new Point(231, 87);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(1102, 23);
            txtMail.TabIndex = 5;
            // 
            // lblCodigoArea
            // 
            lblCodigoArea.Dock = DockStyle.Fill;
            lblCodigoArea.Font = new Font("Segoe UI", 9F);
            lblCodigoArea.Location = new Point(15, 120);
            lblCodigoArea.Name = "lblCodigoArea";
            lblCodigoArea.Padding = new Padding(6, 0, 0, 0);
            lblCodigoArea.Size = new Size(210, 36);
            lblCodigoArea.TabIndex = 6;
            lblCodigoArea.Text = "Código área:";
            lblCodigoArea.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCodigoArea
            // 
            txtCodigoArea.Dock = DockStyle.Fill;
            txtCodigoArea.Font = new Font("Segoe UI", 9F);
            txtCodigoArea.Location = new Point(231, 123);
            txtCodigoArea.Name = "txtCodigoArea";
            txtCodigoArea.Size = new Size(1102, 23);
            txtCodigoArea.TabIndex = 7;
            // 
            // lblTelefono
            // 
            lblTelefono.Dock = DockStyle.Fill;
            lblTelefono.Font = new Font("Segoe UI", 9F);
            lblTelefono.Location = new Point(15, 156);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Padding = new Padding(6, 0, 0, 0);
            lblTelefono.Size = new Size(210, 36);
            lblTelefono.TabIndex = 8;
            lblTelefono.Text = "Teléfono:";
            lblTelefono.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTelefono
            // 
            txtTelefono.Dock = DockStyle.Fill;
            txtTelefono.Font = new Font("Segoe UI", 9F);
            txtTelefono.Location = new Point(231, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(1102, 23);
            txtTelefono.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.Dock = DockStyle.Fill;
            lblDireccion.Font = new Font("Segoe UI", 9F);
            lblDireccion.Location = new Point(15, 192);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Padding = new Padding(6, 0, 0, 0);
            lblDireccion.Size = new Size(210, 32);
            lblDireccion.TabIndex = 10;
            lblDireccion.Text = "Dirección:";
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDireccion
            // 
            txtDireccion.Dock = DockStyle.Fill;
            txtDireccion.Font = new Font("Segoe UI", 9F);
            txtDireccion.Location = new Point(231, 195);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(1102, 23);
            txtDireccion.TabIndex = 11;
            // 
            // lblLimiteCredito
            // 
            lblLimiteCredito.Dock = DockStyle.Fill;
            lblLimiteCredito.Font = new Font("Segoe UI", 9F);
            lblLimiteCredito.Location = new Point(15, 224);
            lblLimiteCredito.Name = "lblLimiteCredito";
            lblLimiteCredito.Padding = new Padding(6, 0, 0, 0);
            lblLimiteCredito.Size = new Size(210, 40);
            lblLimiteCredito.TabIndex = 12;
            lblLimiteCredito.Text = "Límite crédito:";
            lblLimiteCredito.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLimiteCredito
            // 
            txtLimiteCredito.Dock = DockStyle.Fill;
            txtLimiteCredito.Font = new Font("Segoe UI", 9F);
            txtLimiteCredito.Location = new Point(231, 227);
            txtLimiteCredito.Name = "txtLimiteCredito";
            txtLimiteCredito.Size = new Size(1102, 23);
            txtLimiteCredito.TabIndex = 13;
            // 
            // lblCanalLista
            // 
            lblCanalLista.Dock = DockStyle.Fill;
            lblCanalLista.Font = new Font("Segoe UI", 9F);
            lblCanalLista.Location = new Point(15, 264);
            lblCanalLista.Name = "lblCanalLista";
            lblCanalLista.Padding = new Padding(6, 0, 0, 0);
            lblCanalLista.Size = new Size(210, 36);
            lblCanalLista.TabIndex = 14;
            lblCanalLista.Text = "Canal / Lista:";
            lblCanalLista.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbCanalLista
            // 
            cmbCanalLista.Dock = DockStyle.Fill;
            cmbCanalLista.Font = new Font("Segoe UI", 9F);
            cmbCanalLista.Items.AddRange(new object[] { "Minorista", "Mayorista", "Online", "Distribuidor" });
            cmbCanalLista.Location = new Point(231, 267);
            cmbCanalLista.Name = "cmbCanalLista";
            cmbCanalLista.Size = new Size(1102, 23);
            cmbCanalLista.TabIndex = 15;
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnCancelar);
            flowButtons.Controls.Add(btnGuardar);
            flowButtons.Dock = DockStyle.Bottom;
            flowButtons.FlowDirection = FlowDirection.RightToLeft;
            flowButtons.Location = new Point(6, 319);
            flowButtons.Name = "flowButtons";
            flowButtons.Padding = new Padding(12);
            flowButtons.Size = new Size(1348, 62);
            flowButtons.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.FlatStyle = FlatStyle.System;
            btnCancelar.Location = new Point(1234, 15);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(10, 6, 10, 6);
            btnCancelar.Size = new Size(87, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSize = true;
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.Location = new Point(1145, 15);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(10, 6, 10, 6);
            btnGuardar.Size = new Size(83, 36);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AgregarClientes
            // 
            AcceptButton = btnGuardar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(1360, 387);
            Controls.Add(tableLayoutPanel);
            Controls.Add(flowButtons);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AgregarClientes";
            Padding = new Padding(6);
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Agregar cliente";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            flowButtons.ResumeLayout(false);
            flowButtons.PerformLayout();
            ResumeLayout(false);
        }
    }
}