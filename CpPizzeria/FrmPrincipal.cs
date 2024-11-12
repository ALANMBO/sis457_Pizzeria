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

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnlogoInicio_Click_1(object sender, EventArgs e)
        {

        }

        private void MenuVertical_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            new FrmCliente().ShowDialog();
        }

        private void btnEmpleado_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            new FrmProducto().ShowDialog();
        }

        private void btnProvedor_Click_1(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }
    }
}
