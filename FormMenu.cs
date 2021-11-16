using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProveedores = new FormProveedores();
            formProveedores.MdiParent = this;
            formProveedores.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturas = new FormReporteFacturas();
            formReporteFacturas.MdiParent = this;
            formReporteFacturas.Show();
        }

        private void reporteDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProducto = new FormReporteProducto();
            formReporteProducto.MdiParent = this;
            formReporteProducto.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeProducto = new FormReporteProducto();
            formReportedeProducto.MdiParent = this;
            formReportedeProducto.Show();
        }

        private void reporteDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportedeProveedores = new FormReportedeProveedores();
            formReportedeProveedores.MdiParent = this;
            formReportedeProveedores.Show();

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }
    }
}
