using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpPizzeria
{
    public partial class FrmPrincipal : Form
    {
        FrmAutenticacion frmAutenticacion;
        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;

        }


        private void iconrestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconCerrar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            new FrmEmpleado().ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            new FrmVenta().ShowDialog();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            new FrmMenu().ShowDialog();
        }
    }
}
