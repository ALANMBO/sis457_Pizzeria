﻿using CadPizzeria;
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
using System.Xml.Linq;

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
            //Size = new Size(775, 441);
            listar();
        }

        private void listar()
        {
            var empleados = EmpleadoCln.listarPa(txtParametro.Text.Trim());
            dgvLista.DataSource = empleados;
            dgvLista.Columns["idEmpleado"].Visible = false;
            dgvLista.Columns["nombre"].HeaderText = "Nombre";
            dgvLista.Columns["apellidos"].HeaderText = "Apellidos";
            dgvLista.Columns["telefono"].HeaderText = "Telefono";
            dgvLista.Columns["cargo"].HeaderText = "Cargo";
            dgvLista.Columns["salario"].HeaderText = "Salario";
            btnEditar.Enabled = empleados.Count > 0;
            btnEliminar.Enabled = empleados.Count > 0;
            if (empleados.Count > 0) dgvLista.Rows[0].Cells["nombre"].Selected = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
           // Size = new Size(775, 644);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentCell != null)
            {
                esNuevo = false;
               // Size = new Size(775, 644);

                int index = dgvLista.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
                var empleado = EmpleadoCln.get(id);
                txtNombre.Text = empleado.nombre;
                txtApellidos.Text = empleado.apellidos;
                txtTelefono.Text = empleado.telefono;
                cbxCargo.Text = empleado.cargo;
                nudSalario.Value = Convert.ToUInt32(empleado.salario);
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para editar", "::: Pizza - Mensaje :::"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) ListarEmpleados();
        }

        private bool esFormularioValido = true;

        private bool validar()
        {
            bool esValido = true;
            erpNombre.SetError(txtNombre, "");
            erpApellidos.SetError(txtApellidos, "");
            erpTelefono.SetError(txtTelefono, "");
            erpCargo.SetError(cbxCargo, "");
            erpSalario.SetError(nudSalario, "");
            erpUsuario.SetError(txtUsuario, "");

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

            if (!string.IsNullOrEmpty(txtTelefono.Text) && txtTelefono.Text.Length < 8)
            {
                esValido = false;
                erpTelefono.SetError(txtTelefono, "El campo Telefono debe tener al menos 8 caracteres");
            }

            if (cbxCargo.SelectedItem == null || cbxCargo.SelectedItem.ToString() == "Seleccione un cargo")
            {
                esValido = false;
                erpCargo.SetError(cbxCargo, "El campo Cargo es obligatorio");
            }
            else
            {
                esValido = true;
                erpCargo.Clear();
            }




            //if (string.IsNullOrEmpty(cbxCargo.Text)){
              //  esValido = false;
             //   erpCargo.SetError(cbxCargo, "El campo Cargo es obligatorio"); }

            if (nudSalario.Value <= 0)
            {
                esValido = false;
                erpSalario.SetError(nudSalario, "El campo Salario es obligatorio y debe ser mayor a 0");
            }

            if (chkUsuario.Checked && string.IsNullOrEmpty(txtUsuario.Text))
            {
                esValido = false;
                erpUsuario.SetError(txtUsuario, "El campo Usuario es obligatorio si está marcado");
            }

            esFormularioValido = esValido;

            return esValido;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                var empleado = new Empleado
                {
                    nombre = txtNombre.Text.Trim(),
                    apellidos = txtApellidos.Text.Trim(),
                    telefono = txtTelefono.Text,
                    cargo = cbxCargo.Text,
                    salario = (double)nudSalario.Value,
                    usuarioRegistro = Util.usuario.usuario1
                };

                if (esNuevo)
                {
                    empleado.fechaRegistro = DateTime.Now;
                    empleado.estado = 1;
                    int id = EmpleadoCln.insertar(empleado);

                    if (chkUsuario.Checked)
                    {
                        var usuario = new Usuario
                        {
                            usuario1 = txtNombre.Text.Trim(),
                            clave = Util.Encrypt("hola123"),
                            idEmpleado = id,
                            usuarioRegistro = "Elena",
                            fechaRegistro = DateTime.Now,
                            estado = 1
                        };
                        UsuarioCln.insertar(usuario);
                    }
                }
                else
                {
                    if (dgvLista.CurrentCell != null)
                    {
                        int index = dgvLista.CurrentCell.RowIndex;
                        empleado.idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
                        EmpleadoCln.actualizar(empleado);
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un empleado para guardar cambios", "::: Pizza - Mensaje :::"
                            , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //aqui cambie btnCancelar por guardar para cuando quiera guardar un empleado
                //listar();
                ///btnGuardar.PerformClick();
                //MessageBox.Show("Empleado guardado correctamente", "::: Pizza - Mensaje :::"
                   // , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLista.CurrentCell != null)
            {
                int index = dgvLista.CurrentCell.RowIndex;
                int idEmpleado = Convert.ToInt32(dgvLista.Rows[index].Cells["idEmpleado"].Value);
                string nombre = dgvLista.Rows[index].Cells["nombre"].Value.ToString();
                DialogResult dialog = MessageBox.Show($"¿Está seguro que desea dar de baja el empleado {nombre}?", "::: Pizza - Mensaje :::"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    EmpleadoCln.eliminar(idEmpleado, "Juancho");
                    listar();
                    MessageBox.Show("Empleado dado de baja correctamente", "::: Pizza - Mensaje :::"
                        , MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un empleado para eliminar", "::: Pizza - Mensaje :::"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void chkUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Visible = chkUsuario.Checked;
        }
        
    }
}
