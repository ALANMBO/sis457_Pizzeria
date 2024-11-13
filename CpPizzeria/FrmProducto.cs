using CadPizzeria;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarFormulario();
            txtCodigo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["idProducto"].Value);
            var producto = ProductoCln.get(id);
            txtCodigo.Text = producto.codigo;
            txtNombre.Text = producto.nombre;
            txtDescripcion.Text = producto.descripcion;
            nudPrecio.Value = producto.precio;
            nudCategoria.Value = producto.idCategoria;
            nudStock.Value = producto.stock;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarProductos();
            txtBuscar.Clear();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) ListarProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarProducto();
                ListarProductos();

                MessageBox.Show("Producto guardado correctamente", "::: Cafeteria - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarProducto()
        {
            var producto = new Producto
            {
                idCategoria = (int)nudCategoria.Value,
                codigo = txtCodigo.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                descripcion = txtDescripcion.Text.Trim(),
                precio = nudPrecio.Value,
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1,
                stock = (int)nudStock.Value 
            };

            if (esNuevo)
            {
                ProductoCln.insertar(producto);
            }
            else
            {
                int index = dgvLista.CurrentCell.RowIndex;
                producto.idProducto = Convert.ToInt32(dgvLista.Rows[index].Cells["idProducto"].Value);
                ProductoCln.actualizar(producto);
            }
        }

        private bool ValidarCampos()
        {
            bool esValido = true;
            erpCodigo.Clear();
            erpNombre.Clear();
            erpPrecio.Clear();
            erpStock.Clear(); 

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                esValido = false;
                erpCodigo.SetError(txtCodigo, "El campo Codigo es obligatorio");
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (nudPrecio.Value <= 0)
            {
                esValido = false;
                erpPrecio.SetError(nudPrecio, "El campo Precio es obligatorio");
            }
            if (nudStock.Value < 0) 
            {
                esValido = false;
                erpStock.SetError(nudStock, "El campo Stock no puede ser negativo");
            }

            return esValido;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void EliminarProducto()
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int idProducto = Convert.ToInt32(dgvLista.Rows[index].Cells["idProducto"].Value);
            string codigo = dgvLista.Rows[index].Cells["codigo"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar el producto {codigo}?", "::: Pizzeria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                ProductoCln.eliminar(idProducto, "pizzaHouse");
                ListarProductos();
                MessageBox.Show("Producto dado de baja correctamente", "::: Pizzeria - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            nudPrecio.Value = 0;
            nudCategoria.Value = 0;
            nudStock.Value = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
