using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHSistemaDeInventario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            ListadoClientes ventanaClientes = new ListadoClientes();
            ventanaClientes.Show();

            // Oculta la ventana Principal
            this.Hide();
        }
    }
}
