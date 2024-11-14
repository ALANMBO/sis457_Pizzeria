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
                
                int id = 0;
                decimal precio = 0;
                if (!int.TryParse(tbxIdProducto.Text.Trim(), out id)) 
                {
                    MessageBox.Show("ID del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!decimal.TryParse(txtPrecio.Text.Trim(), out precio)) 
                {
                    MessageBox.Show("Precio del producto no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                string producto = CbxProducto.Text.Trim();
                int cantidad = (int)nudCantidadP.Value;
                int stockDisponible = (int)nudStock.Value;

                if (cantidad > stockDisponible)
                {
                    MessageBox.Show("Cantidad solicitada supera el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal subtotal = precio * cantidad;

               
                dvgListaVenta.Rows.Add(id, producto, precio, cantidad, subtotal);
                sumaTotal += subtotal; 

                
                txtTotal.Text = sumaTotal.ToString("N2", CultureInfo.CreateSpecificCulture("en-US")); 

                
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
            
            if (CbxProducto.SelectedIndex == -1)
            {
                esValido = false;
                erpProducto.SetError(CbxProducto, "Debe seleccionar un producto");
            }
            return esValido;
        }

        private void CbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxProducto.SelectedItem != null)
            {
                Producto productoSeleccionado = (Producto)CbxProducto.SelectedItem;
                tbxIdProducto.Text = productoSeleccionado.idProducto.ToString();
                txtPrecio.Text = productoSeleccionado.precio.ToString();
                txtCodigo.Text = productoSeleccionado.codigo.ToString();

                
                int stock = productoSeleccionado.stock;
                if (stock < nudStock.Minimum)
                {
                    stock = (int)nudStock.Minimum;
                }
                else if (stock > nudStock.Maximum)
                {
                    stock = (int)nudStock.Maximum;
                }

                nudStock.Value = stock; 
            }
            else
            {
                limpiar(); 
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dvgListaVenta.Rows.Count == 0)
            {
                MessageBox.Show("Debes agregar al menos un producto antes de crear la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var cliente = new Cliente
            {
                razonSocial = txtrazonSocial.Text.Trim(),
                cedulaIdentidad = txtNit.Text.Trim(),
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };
            int idCliente = ClienteCln.insertar(cliente); 

           
            decimal totalVenta = 0;
            if (!decimal.TryParse(txtTotal.Text.Trim(), out totalVenta))
            {
                MessageBox.Show("Total de la venta no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            var venta = new Venta
            {
                idUsuario = Util.usuario.idUsuario,
                idCliente = idCliente,
                totalVenta = totalVenta,
                fechaVenta = DateTime.Now,
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };
            int idVenta = VentaCln.insertar(venta); 

           
            foreach (DataGridViewRow row in dvgListaVenta.Rows)
            {
                int idProducto = Convert.ToInt32(row.Cells["dvgIdProducto"].Value);
                int cantidad = Convert.ToInt32(row.Cells["dvgCantidad"].Value);
                decimal precio = Convert.ToDecimal(row.Cells["dvgPrecio"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["dvgSubTotal"].Value);

                var ventaDetalle = new VentaDetalle
                {
                    idVenta = idVenta,
                    idProducto = idProducto,
                    cantidad = cantidad,
                    precioUnitario = precio,
                    total = subtotal,
                    usuarioRegistro = Util.usuario.usuario1,
                    fechaRegistro = DateTime.Now,
                    estado = 1
                };

                VentaDetalleCln.insertar(ventaDetalle);

               
                Producto producto = ProductoCln.obtener(idProducto);
                if (producto != null)
                {
                    producto.stock -= cantidad;
                    ProductoCln.actualizar(producto);
                }
            }

            
            txtTotal.Text = string.Empty;
            sumaTotal = 0;
            dvgListaVenta.Rows.Clear();
            MessageBox.Show("Venta guardada exitosamente", "::: Pizza - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FrmProducto productoForm = new FrmProducto();

            productoForm.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
