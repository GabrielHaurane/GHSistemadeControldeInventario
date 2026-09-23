using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GHSistemaDeInventario
{
    public partial class ListadoClientes : Form
    {
        public ListadoClientes()
        {
            InitializeComponent();
        }
        private async void ListadoClientes_Load(object sender, EventArgs e)
        {
            await CargarClientesAsync();
        }


        private async Task CargarClientesAsync()
        {
            // 1. Mostrar el indicador de carga y desactivar la grilla para evitar interacción
            lblCargando.Visible = true;
            progressBarCarga.Visible = true;
            dgvClientes.Enabled = false;

            try
            {
                // 2. Ejecutar la consulta pesada fuera del hilo de la interfaz
                DataTable dt = await Task.Run(() =>
                {
                    using (var conexion = Sesion.ObtenerConexion())
                    {
                        conexion.Open();
                        string consulta = "SELECT * FROM cliente";

                        using (MySqlCommand comando = new MySqlCommand(consulta, conexion))
                        {
                            using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                            {
                                DataTable tabla = new DataTable();
                                adaptador.Fill(tabla);
                                return tabla;
                            }
                        }
                    }
                });

                // 3. De vuelta en el hilo principal: enlazar los datos
                dgvClientes.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // 4. Ocultar el indicador pase lo que pase
                lblCargando.Visible = false;
                progressBarCarga.Visible = false;
                dgvClientes.Enabled = true;
            }

        }

        private void agregar_clientes_nuevos_Click(object sender, EventArgs e)
        {
            AgregarClientes ventanaAgregarClientes = new AgregarClientes();
            ventanaAgregarClientes.Show();

            // Oculta la ventana Principal
            this.Hide();
        }
    }
}