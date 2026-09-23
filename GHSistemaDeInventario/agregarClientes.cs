using System;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GHSistemaDeInventario
{
    public partial class AgregarClientes : Form
    {
        public AgregarClientes()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
            {
                MessageBox.Show("La razón social es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRazonSocial.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCuitCuil.Text))
            {
                MessageBox.Show("El CUIT/CUIL es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCuitCuil.Focus();
                return;
            }

            decimal limiteCredito = 0m;
            var textoLimite = txtLimiteCredito.Text?.Trim();
            if (!string.IsNullOrEmpty(textoLimite))
            {
                if (!decimal.TryParse(textoLimite, NumberStyles.Number, CultureInfo.InvariantCulture, out limiteCredito))
                {
                    if (!decimal.TryParse(textoLimite, NumberStyles.Number, CultureInfo.CurrentCulture, out limiteCredito))
                    {
                        MessageBox.Show("Límite de crédito inválido. Introduzca un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtLimiteCredito.Focus();
                        return;
                    }
                }
            }
            else
            {
                limiteCredito = 0m;
            }

            try
            {
                using (var conexion = Sesion.ObtenerConexion())
                {
                    conexion.Open();

                    using (var cmd = new MySqlCommand())
                    {
                        cmd.Connection = conexion;
                        cmd.CommandText = @"INSERT INTO cliente (razon_social, cuit_cuil, mail, codigo_area, telefono, direccion, limite_credito, canal_lista) VALUES (@razon, @cuit, @mail, @codigo, @telefono, @direccion, @limite, @canal);";
                        cmd.Parameters.AddWithValue("@razon", txtRazonSocial.Text.Trim());
                        cmd.Parameters.AddWithValue("@cuit", txtCuitCuil.Text.Trim());
                        cmd.Parameters.AddWithValue("@mail", string.IsNullOrWhiteSpace(txtMail.Text) ? (object)DBNull.Value : txtMail.Text.Trim());
                        cmd.Parameters.AddWithValue("@codigo", string.IsNullOrWhiteSpace(txtCodigoArea.Text) ? (object)DBNull.Value : txtCodigoArea.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefono", string.IsNullOrWhiteSpace(txtTelefono.Text) ? (object)DBNull.Value : txtTelefono.Text.Trim());
                        cmd.Parameters.AddWithValue("@direccion", string.IsNullOrWhiteSpace(txtDireccion.Text) ? (object)DBNull.Value : txtDireccion.Text.Trim());
                        cmd.Parameters.AddWithValue("@limite", limiteCredito);
                        cmd.Parameters.AddWithValue("@canal", string.IsNullOrWhiteSpace(cmbCanalLista.Text) ? (object)DBNull.Value : cmbCanalLista.Text.Trim());

                        int afectadas = cmd.ExecuteNonQuery();
                        if (afectadas > 0)
                        {
                            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el cliente. No se afectaron filas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al acceder a la base de datos: {ex.Message}", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}