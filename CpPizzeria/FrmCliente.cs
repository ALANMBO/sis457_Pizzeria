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
    public partial class FrmCliente : Form
    {
        bool esNuevo = false;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void pnlAcciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbxLista_Enter(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            //Size = new Size(860, 349); 
            listar();
        }

        private void listar()
        {
            var clientes = ClienteCln.listarPa(txtBuscar.Text.Trim()); 
            dgvLista.DataSource = clientes;


            if (dgvLista.Columns.Contains("id"))
                dgvLista.Columns["id"].Visible = false; 
            if (dgvLista.Columns.Contains("estado"))
                dgvLista.Columns["estado"].Visible = false; 
            if (dgvLista.Columns.Contains("razonSocial"))
                dgvLista.Columns["razonSocial"].HeaderText = "Razón Social"; 
            if (dgvLista.Columns.Contains("cedulaIdentidad"))
                dgvLista.Columns["cedulaIdentidad"].HeaderText = "nit"; 
            if (dgvLista.Columns.Contains("celular"))
                dgvLista.Columns["celular"].HeaderText = "Celular"; 
            if (dgvLista.Columns.Contains("usuarioRegistro"))
                dgvLista.Columns["usuarioRegistro"].HeaderText = "Usuario Registro"; 
            if (dgvLista.Columns.Contains("fechaRegistro"))
                dgvLista.Columns["fechaRegistro"].HeaderText = "Fecha de Registro";


            bool hayClientes = clientes.Count > 0;
            btnEditar.Enabled = hayClientes;
            btnEliminar.Enabled = hayClientes;

            if (hayClientes)
                dgvLista.Rows[0].Cells["razonSocial"].Selected = true;
        }


      

       

        private void limpiar()
        {
            txtRazon.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCelular.Text = string.Empty;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private bool Validar()
        {
            bool esValido = true; 
            erpRazonsocial.SetError(txtRazon, "");
            erpCedula.SetError(txtCedula, "");
            erpCelular.SetError(txtCelular, "");

            
            if (string.IsNullOrEmpty(txtRazon.Text))
            {
                esValido = false;
                erpRazonsocial.SetError(txtRazon, "El campo Razón Social es obligatorio");
            }

           
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                esValido = false;
                erpCedula.SetError(txtCedula, "El campo Cédula es obligatorio");
            }

            if (string.IsNullOrEmpty(txtCelular.Text))
            {
                esValido = false;
                erpCelular.SetError(txtCelular, "El campo Celular es obligatorio");
            }

            return esValido; 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            //Size = new Size(955, 487); 
            limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            Size = new Size();
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            var cliente = ClienteCln.get(id);

            txtRazon.Text = cliente.razonSocial;
            txtCedula.Text = cliente.cedulaIdentidad;
            txtCelular.Text = cliente.celular;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
            string razonSocial = dgvLista.Rows[index].Cells["razonSocial"].Value.ToString();


            DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el cliente {razonSocial}?",
                "::: Pizzeria - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);


            if (dialog == DialogResult.OK)
            {
                ClienteCln.eliminar(id, "SIS457");
                listar();
                MessageBox.Show("Cliente dado de baja correctamente", "::: Pizzeria - Mensaje :::",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
            txtBuscar.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                var cliente = new Cliente
                {
                    razonSocial = txtRazon.Text.Trim(),
                    cedulaIdentidad = txtCedula.Text.Trim(),
                    celular = txtCelular.Text,
                    usuarioRegistro = Util.usuario.usuario1
                };

                if (esNuevo)
                {
                    cliente.fechaRegistro = DateTime.Now;
                    cliente.estado = 1;
                    ClienteCln.insertar(cliente);
                }
                else
                {
                    int index = dgvLista.CurrentCell.RowIndex;
                    cliente.id = Convert.ToInt32(dgvLista.Rows[index].Cells["id"].Value);
                    ClienteCln.actualizar(cliente);
                }

                listar();
                // Size = new Size(678, 487); 
                limpiar();
            }
        }
    }
}
