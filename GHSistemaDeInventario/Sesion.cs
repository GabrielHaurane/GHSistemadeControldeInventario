using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GHSistemaDeInventario
{
    public static class Sesion
    {
        public static string CadenaConexion { get; set; }

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(CadenaConexion);
        }
    }

    public partial class Inicio_Sesion : Form
    {
        public Inicio_Sesion()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Oculta los caracteres de la contraseña
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // 1. Validación previa
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = $"Server=localhost;Database=sistemadeinventariobd;Uid={usuario};Pwd={password};";

            // 2. Intento de conexión
            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    Sesion.CadenaConexion = connectionString;

                    Principal ventanaPrincipal = new Principal();
                    ventanaPrincipal.Show();
                    this.Hide();
                }
                catch (MySqlException ex)
                {
                    // Captura errores específicos de MySQL (credenciales erróneas, servidor apagado, etc.)
                    MessageBox.Show("Error de autenticación o conexión: " + ex.Message, "Error MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}