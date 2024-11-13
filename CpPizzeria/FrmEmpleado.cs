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
    public partial class FrmEmpleado : Form
    {
        bool esNuevo = false;
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            var empleados = EmpleadoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = empleados;
            ConfigurarDataGridView();
            HabilitarBotones(empleados.Count > 0);
        }

        private void HabilitarBotones(bool habilitar)
        {
            btnEditar.Enabled = habilitar;
            btnEliminar.Enabled = habilitar;
            if (habilitar) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void ConfigurarDataGridView()
        {
            dgvLista.Columns["idEmpleado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["apellidos"].HeaderText = "Apellidos";
            dgvLista.Columns["telefono"].HeaderText = "Telefono";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["salario"].HeaderText = "Salario";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            //LimpiarFormulario();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            esNuevo = false;
            CargarDatosEmpleado();
        }

        private void CargarDatosEmpleado()
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
            var empleado = EmpleadoCln.get(id);
            txtNombre.Text = empleado.nombre;
            txtApellidos.Text = empleado.apellidos;
            txtTelefono.Text = empleado.telefono;
            cbxCargo.Text = empleado.cargo;
            nudSalario.Value = Convert.ToDecimal(empleado.salario);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = dgvLista.CurrentCell.RowIndex;
            int idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
            string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
            DialogResult dialog = MessageBox.Show($"¿Está seguro de eliminar al empleado {nombre}?", "::: Pizza - Mensaje :::", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                EmpleadoCln.eliminar(idEmpleado, "cafeteria");
                ListarEmpleados();
                MessageBox.Show("Empleado eliminado correctamente", "::: Pizza - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                GuardarEmpleado();
                ListarEmpleados();

                MessageBox.Show("Empleado guardado correctamente", "::: Pizza - Mensaje :::", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GuardarEmpleado()
        {
            var empleado = new Empleado
            {
                nombre = txtNombre.Text.Trim(),
                apellidos = txtApellidos.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                cargo = cbxCargo.Text,
                salario = Convert.ToDouble(nudSalario.Value),
                usuarioRegistro = Util.usuario.usuario1,
                fechaRegistro = DateTime.Now,
                estado = 1
            };

            if (esNuevo)
            {
                int id = EmpleadoCln.insertar(empleado);
            }
            else
            {
                int index = dgvLista.CurrentCell.RowIndex;
                empleado.idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
                EmpleadoCln.actualizar(empleado);
            }
        }

        private bool ValidarCampos()
        {
            bool esValido = true;
            erpNombre.Clear();
            erpApellidos.Clear();
            erpTelefono.Clear();
            erpCargo.Clear();
            erpSalario.Clear();


            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                erpNombre.SetError(txtNombre, "El campo Nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(txtApellidos.Text))
            {
                esValido = false;
                erpApellidos.SetError(txtApellidos, "El campo Apellidos es obligatorio");
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo Telefono es obligatorio");
            }
            if (string.IsNullOrEmpty(cbxCargo.Text))
            {
                esValido = false;
                erpCargo.SetError(cbxCargo, "El campo Cargo es obligatorio");
            }
            if (nudSalario.Value <= 0)
            {
                esValido = false;
                erpSalario.SetError(nudSalario, "El campo Salario es obligatorio");
            }

            return esValido;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarEmpleados();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) ListarEmpleados();
        }
    }
}
