using ClnPizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpPizzeria
{
    public partial class FrmProducto : Form
    {
        private bool esNuevo = false;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            //AjustarTamañoFormulario();
            ListarProductos();
        }

        private void ListarProductos()
        {
            var productos = ProductoCln.listarPa(txtBuscar.Text.Trim());
            dgvLista.DataSource = productos;
            ConfigurarDataGridView();
            HabilitarBotones(productos.Count > 0);
        }

        private void HabilitarBotones(bool habilitar)
        {
            btnEditar.Enabled = habilitar;
            btnEliminar.Enabled = habilitar;
            if (habilitar) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void ConfigurarDataGridView()
        {
            if (dgvLista.Columns["idProducto"] != null)
                dgvLista.Columns["idProducto"].Visible = false;

            if (dgvLista.Columns["idCategoria"] != null)
                dgvLista.Columns["idCategoria"].Visible = false;

            if (dgvLista.Columns["estado"] != null)
                dgvLista.Columns["estado"].Visible = false;

            if (dgvLista.Columns["codigo"] != null)
                dgvLista.Columns["codigo"].HeaderText = "Codigo";

            if (dgvLista.Columns["nombre"] != null)
                dgvLista.Columns["nombre"].HeaderText = "Nombre";

            if (dgvLista.Columns["descripcion"] != null)
                dgvLista.Columns["descripcion"].HeaderText = "Descripcion";

            if (dgvLista.Columns["precio"] != null)
                dgvLista.Columns["precio"].HeaderText = "Precio";

            if (dgvLista.Columns["usuarioRegistro"] != null)
                dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro";

            if (dgvLista.Columns["categoria"] != null)
                dgvLista.Columns["categoria"].HeaderText = "Categoria";

            if (dgvLista.Columns["stock"] != null)
                dgvLista.Columns["stock"].HeaderText = "Stock";
        }
    }
}
