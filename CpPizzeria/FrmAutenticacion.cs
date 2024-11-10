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
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
            // txtClave.Text = Util.Encrypt("hola123"); //este codigo lo empcipta  

        }

        private void FrmAutenticacion_Load(object sender, EventArgs e)
        {

        }
        private bool validar()
        {
            bool esValido = true;
            erpUsuario.SetError(txtUsuario, "");
            erpClave.SetError(txtClave, "");

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                erpUsuario.SetError(txtUsuario, "El campo usuario es obligatorio");
                esValido = false;
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                erpClave.SetError(txtClave, "El campo contraseña es obligatorio");
                esValido = false;
            }
            return esValido;
        }
        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            if (validar())
            {
                var usuario = UsuarioCln.validar(txtUsuario.Text, Util.Encrypt(txtClave.Text));
                if (usuario != null)
                {
                    Util.usuario = usuario;
                    txtUsuario.Focus();
                    txtUsuario.SelectAll();
                    Visible = false;
                    new FrmPrincipal(this).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto", "::: Error - Mensaje :::",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnIniciar.PerformClick();
        }

 
    }
}
