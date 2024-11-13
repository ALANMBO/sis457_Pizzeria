using CadPizzeria;
using ClnPizzeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpPizzeria
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }


        private void gbxProducto_Enter(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoCln.listar();
            if (productos.Count > 0)
            {
                CbxProducto.DataSource = productos;
                CbxProducto.ValueMember = "idProducto"; 
                CbxProducto.SelectedIndex = -1; 

                tbxIdProducto.Enabled = false;
                txtPrecio.Enabled = false;
                txtCodigo.Enabled = false;
            }
        }
        decimal sumaTotal = 0;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                // Intenta obtener el ID y el precio del producto
                int id = 0;
                decimal precio = 0;
                if (!int.TryParse(tbxIdProducto.Text.Trim(), out id)) // Si el ID no es válido
                {
                    MessageBox.Show("ID del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio)) // Si el precio no es válido
                {
                    MessageBox.Show("Precio del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtiene el producto seleccionado, la cantidad y verifica el stock disponible
                string producto = CbxProducto.Text.Trim();
                int cantidad = (int)nudCantidadP.Value;
                int stockDisponible = (int)nudStock.Value;

                if (cantidad > stockDisponible)
                {
                    MessageBox.Show("Cantidad solicitada supera el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal subtotal = precio * cantidad;

                // Agrega el producto a la grilla de la venta
                dvgListaVenta.Rows.Add(id, producto, precio, cantidad, subtotal);
                sumaTotal += subtotal; // Suma el subtotal al total acumulado

                // Actualiza el total en la interfaz de usuario
                txtTotal.Text = sumaTotal.ToString("N2", CultureInfo.CreateSpecificCulture("en-US")); // Formatea el total como moneda

                // Limpia los campos para la próxima adición
                limpiar();
            }
        }

        private void limpiar()
        {
            txtCodigo.Text = string.Empty;
            CbxProducto.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            nudCantidadP.Value = 1;
        }

        private bool validar()
        {
            bool esValido = true;
            
            erpNit.SetError(txtNit, "");
            erpRazonSocial.SetError(txtrazonSocial, "");
            erpProducto.SetError(CbxProducto, "");

            // Verifica si los campos requeridos están vacíos
            if (string.IsNullOrEmpty(txtNit.Text))
            {
                esValido = false;
                erpNit.SetError(txtNit, "El campo Carnet de Identidad es obligatorio");
            }
            if (string.IsNullOrEmpty(txtrazonSocial.Text))
            {
                esValido = false;
                erpRazonSocial.SetError(txtrazonSocial, "El campo Razon Social es obligatorio");
            }
            //if (string.IsNullOrEmpty(txtCelular.Text))
            //{
               /// esValido = false;
                ///erpCelular.SetError(txtCelular, "El campo celular es obligatorio");
            ///}
            if (CbxProducto.SelectedIndex == -1)
            {
                esValido = false;
                erpProducto.SetError(CbxProducto, "Debe seleccionar un producto");
            }
            return esValido;
        }
    }
}
