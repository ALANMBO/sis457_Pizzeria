namespace CpPizzeria
{
    partial class FrmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.lblTotal = new System.Windows.Forms.Label();
            this.dvgListaVenta = new System.Windows.Forms.DataGridView();
            this.dvgIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxProducto = new System.Windows.Forms.GroupBox();
            this.txtPrecio1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudStock = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudCantidadP = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbxProducto = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtrazonSocial = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNit = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.gbxVenta = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tbxIdProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.erpNit = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpRazonSocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpProducto = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVolver = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrarVenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregar = new Guna.UI2.WinForms.Guna2Button();
            this.btnBuscar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaVenta)).BeginInit();
            this.gbxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadP)).BeginInit();
            this.gbxCliente.SuspendLayout();
            this.gbxVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(15, 455);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 19);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total";
            // 
            // dvgListaVenta
            // 
            this.dvgListaVenta.AllowUserToAddRows = false;
            this.dvgListaVenta.AllowUserToDeleteRows = false;
            this.dvgListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dvgIdProducto,
            this.dvgProducto,
            this.dvgPrecio,
            this.dvgCantidad,
            this.dvgSubTotal});
            this.dvgListaVenta.Location = new System.Drawing.Point(5, 284);
            this.dvgListaVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvgListaVenta.Name = "dvgListaVenta";
            this.dvgListaVenta.ReadOnly = true;
            this.dvgListaVenta.RowHeadersWidth = 51;
            this.dvgListaVenta.Size = new System.Drawing.Size(722, 146);
            this.dvgListaVenta.TabIndex = 24;
            // 
            // dvgIdProducto
            // 
            this.dvgIdProducto.HeaderText = "IdProducto";
            this.dvgIdProducto.MinimumWidth = 6;
            this.dvgIdProducto.Name = "dvgIdProducto";
            this.dvgIdProducto.ReadOnly = true;
            this.dvgIdProducto.Visible = false;
            this.dvgIdProducto.Width = 125;
            // 
            // dvgProducto
            // 
            this.dvgProducto.HeaderText = "Producto";
            this.dvgProducto.MinimumWidth = 6;
            this.dvgProducto.Name = "dvgProducto";
            this.dvgProducto.ReadOnly = true;
            this.dvgProducto.Width = 200;
            // 
            // dvgPrecio
            // 
            this.dvgPrecio.HeaderText = "Precio";
            this.dvgPrecio.MinimumWidth = 6;
            this.dvgPrecio.Name = "dvgPrecio";
            this.dvgPrecio.ReadOnly = true;
            this.dvgPrecio.Width = 120;
            // 
            // dvgCantidad
            // 
            this.dvgCantidad.HeaderText = "Cantidad";
            this.dvgCantidad.MinimumWidth = 6;
            this.dvgCantidad.Name = "dvgCantidad";
            this.dvgCantidad.ReadOnly = true;
            this.dvgCantidad.Width = 120;
            // 
            // dvgSubTotal
            // 
            this.dvgSubTotal.HeaderText = "Sub Total";
            this.dvgSubTotal.MinimumWidth = 6;
            this.dvgSubTotal.Name = "dvgSubTotal";
            this.dvgSubTotal.ReadOnly = true;
            this.dvgSubTotal.Width = 120;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Black;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(-1, 1);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(728, 38);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Ventas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxProducto
            // 
            this.gbxProducto.BackColor = System.Drawing.Color.Black;
            this.gbxProducto.BackgroundImage = global::CpPizzeria.Properties.Resources.pizzaback;
            this.gbxProducto.Controls.Add(this.btnAgregar);
            this.gbxProducto.Controls.Add(this.txtPrecio1);
            this.gbxProducto.Controls.Add(this.btnBuscar);
            this.gbxProducto.Controls.Add(this.nudStock);
            this.gbxProducto.Controls.Add(this.nudCantidadP);
            this.gbxProducto.Controls.Add(this.txtCodigo);
            this.gbxProducto.Controls.Add(this.CbxProducto);
            this.gbxProducto.Controls.Add(this.gbxCliente);
            this.gbxProducto.Controls.Add(this.txtPrecio);
            this.gbxProducto.Controls.Add(this.gbxVenta);
            this.gbxProducto.Controls.Add(this.lbl);
            this.gbxProducto.Controls.Add(this.lblCantidad);
            this.gbxProducto.Controls.Add(this.lblCodigo);
            this.gbxProducto.Controls.Add(this.tbxIdProducto);
            this.gbxProducto.Controls.Add(this.lblNombre);
            this.gbxProducto.Controls.Add(this.lblPrecio);
            this.gbxProducto.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProducto.ForeColor = System.Drawing.Color.White;
            this.gbxProducto.Location = new System.Drawing.Point(5, 43);
            this.gbxProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxProducto.Name = "gbxProducto";
            this.gbxProducto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxProducto.Size = new System.Drawing.Size(722, 225);
            this.gbxProducto.TabIndex = 21;
            this.gbxProducto.TabStop = false;
            this.gbxProducto.Text = "Información del Producto";
            this.gbxProducto.Enter += new System.EventHandler(this.gbxProducto_Enter);
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.BorderColor = System.Drawing.Color.Black;
            this.txtPrecio1.BorderRadius = 13;
            this.txtPrecio1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio1.DefaultText = "";
            this.txtPrecio1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio1.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtPrecio1.ForeColor = System.Drawing.Color.Black;
            this.txtPrecio1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio1.Location = new System.Drawing.Point(427, 140);
            this.txtPrecio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.PasswordChar = '\0';
            this.txtPrecio1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPrecio1.PlaceholderText = "";
            this.txtPrecio1.SelectedText = "";
            this.txtPrecio1.Size = new System.Drawing.Size(107, 30);
            this.txtPrecio1.TabIndex = 20;
            // 
            // nudStock
            // 
            this.nudStock.BackColor = System.Drawing.Color.Transparent;
            this.nudStock.BorderColor = System.Drawing.Color.Black;
            this.nudStock.BorderRadius = 13;
            this.nudStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudStock.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.nudStock.Location = new System.Drawing.Point(242, 176);
            this.nudStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(149, 33);
            this.nudStock.TabIndex = 19;
            this.nudStock.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nudStock.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // nudCantidadP
            // 
            this.nudCantidadP.BackColor = System.Drawing.Color.Transparent;
            this.nudCantidadP.BorderColor = System.Drawing.Color.Black;
            this.nudCantidadP.BorderRadius = 13;
            this.nudCantidadP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCantidadP.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.nudCantidadP.Location = new System.Drawing.Point(243, 114);
            this.nudCantidadP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudCantidadP.Name = "nudCantidadP";
            this.nudCantidadP.Size = new System.Drawing.Size(149, 33);
            this.nudCantidadP.TabIndex = 18;
            this.nudCantidadP.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nudCantidadP.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderColor = System.Drawing.Color.Black;
            this.txtCodigo.BorderRadius = 13;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.Location = new System.Drawing.Point(7, 101);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.Size = new System.Drawing.Size(133, 30);
            this.txtCodigo.TabIndex = 17;
            // 
            // CbxProducto
            // 
            this.CbxProducto.BackColor = System.Drawing.Color.Transparent;
            this.CbxProducto.BorderColor = System.Drawing.Color.Black;
            this.CbxProducto.BorderRadius = 13;
            this.CbxProducto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxProducto.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbxProducto.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.CbxProducto.ForeColor = System.Drawing.Color.Black;
            this.CbxProducto.ItemHeight = 30;
            this.CbxProducto.Location = new System.Drawing.Point(7, 164);
            this.CbxProducto.Name = "CbxProducto";
            this.CbxProducto.Size = new System.Drawing.Size(124, 36);
            this.CbxProducto.TabIndex = 16;
            this.CbxProducto.SelectedIndexChanged += new System.EventHandler(this.CbxProducto_SelectedIndexChanged);
            // 
            // gbxCliente
            // 
            this.gbxCliente.BackColor = System.Drawing.Color.Black;
            this.gbxCliente.Controls.Add(this.txtrazonSocial);
            this.gbxCliente.Controls.Add(this.txtNit);
            this.gbxCliente.Controls.Add(this.lblRazonSocial);
            this.gbxCliente.Controls.Add(this.lblNit);
            this.gbxCliente.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCliente.ForeColor = System.Drawing.Color.White;
            this.gbxCliente.Location = new System.Drawing.Point(243, 21);
            this.gbxCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxCliente.Size = new System.Drawing.Size(434, 69);
            this.gbxCliente.TabIndex = 9;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Informacion del Cliente";
            // 
            // txtrazonSocial
            // 
            this.txtrazonSocial.BorderColor = System.Drawing.Color.Black;
            this.txtrazonSocial.BorderRadius = 13;
            this.txtrazonSocial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtrazonSocial.DefaultText = "";
            this.txtrazonSocial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtrazonSocial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtrazonSocial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtrazonSocial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtrazonSocial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrazonSocial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtrazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtrazonSocial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtrazonSocial.Location = new System.Drawing.Point(294, 19);
            this.txtrazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrazonSocial.Name = "txtrazonSocial";
            this.txtrazonSocial.PasswordChar = '\0';
            this.txtrazonSocial.PlaceholderText = "";
            this.txtrazonSocial.SelectedText = "";
            this.txtrazonSocial.Size = new System.Drawing.Size(128, 32);
            this.txtrazonSocial.TabIndex = 27;
            // 
            // txtNit
            // 
            this.txtNit.BorderColor = System.Drawing.Color.Black;
            this.txtNit.BorderRadius = 13;
            this.txtNit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNit.DefaultText = "";
            this.txtNit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNit.ForeColor = System.Drawing.Color.Black;
            this.txtNit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNit.Location = new System.Drawing.Point(58, 19);
            this.txtNit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNit.Name = "txtNit";
            this.txtNit.PasswordChar = '\0';
            this.txtNit.PlaceholderText = "";
            this.txtNit.SelectedText = "";
            this.txtNit.Size = new System.Drawing.Size(128, 32);
            this.txtNit.TabIndex = 26;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazonSocial.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.Location = new System.Drawing.Point(187, 26);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(111, 17);
            this.lblRazonSocial.TabIndex = 3;
            this.lblRazonSocial.Text = "Razón Social:";
            this.lblRazonSocial.Click += new System.EventHandler(this.lblRazonSocial_Click);
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.BackColor = System.Drawing.Color.Transparent;
            this.lblNit.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(20, 26);
            this.lblNit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(40, 19);
            this.lblNit.TabIndex = 2;
            this.lblNit.Text = "Nit:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(21, 241);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(132, 22);
            this.txtPrecio.TabIndex = 13;
            // 
            // gbxVenta
            // 
            this.gbxVenta.BackColor = System.Drawing.Color.Black;
            this.gbxVenta.Controls.Add(this.dtpFecha);
            this.gbxVenta.Controls.Add(this.lblFecha);
            this.gbxVenta.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVenta.ForeColor = System.Drawing.Color.White;
            this.gbxVenta.Location = new System.Drawing.Point(9, 21);
            this.gbxVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxVenta.Name = "gbxVenta";
            this.gbxVenta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxVenta.Size = new System.Drawing.Size(226, 51);
            this.gbxVenta.TabIndex = 10;
            this.gbxVenta.TabStop = false;
            this.gbxVenta.Text = "Infromación Venta";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(63, 19);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(145, 22);
            this.dtpFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(8, 20);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 15);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(238, 154);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(185, 19);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Numero de Productos";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(240, 92);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(188, 19);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad De Producto";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(8, 76);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(66, 19);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // tbxIdProducto
            // 
            this.tbxIdProducto.Location = new System.Drawing.Point(109, 74);
            this.tbxIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxIdProducto.Name = "tbxIdProducto";
            this.tbxIdProducto.Size = new System.Drawing.Size(31, 22);
            this.tbxIdProducto.TabIndex = 6;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(8, 140);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(174, 19);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Selecionar Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(454, 117);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 19);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderColor = System.Drawing.Color.Black;
            this.txtTotal.BorderRadius = 13;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(74, 455);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(133, 30);
            this.txtTotal.TabIndex = 31;
            // 
            // erpNit
            // 
            this.erpNit.ContainerControl = this;
            // 
            // erpRazonSocial
            // 
            this.erpRazonSocial.ContainerControl = this;
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // erpProducto
            // 
            this.erpProducto.ContainerControl = this;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BorderRadius = 13;
            this.btnVolver.BorderThickness = 1;
            this.btnVolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVolver.FillColor = System.Drawing.Color.White;
            this.btnVolver.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Image = global::CpPizzeria.Properties.Resources.seo_social_web_network_internet_322_icon_icons_com_61532;
            this.btnVolver.Location = new System.Drawing.Point(678, 2);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(49, 33);
            this.btnVolver.TabIndex = 32;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarVenta.BorderRadius = 13;
            this.btnRegistrarVenta.BorderThickness = 1;
            this.btnRegistrarVenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarVenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrarVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrarVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrarVenta.FillColor = System.Drawing.Color.White;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.Image = global::CpPizzeria.Properties.Resources.concertticket_83678;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(214, 455);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(51, 33);
            this.btnRegistrarVenta.TabIndex = 31;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.BorderRadius = 13;
            this.btnAgregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregar.FillColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::CpPizzeria.Properties.Resources.add_icon_icons_com_65126;
            this.btnAgregar.Location = new System.Drawing.Point(580, 164);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 36);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BorderRadius = 13;
            this.btnBuscar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBuscar.FillColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::CpPizzeria.Properties.Resources.searcher_magnifyng_glass_search_locate_find_icon_123813;
            this.btnBuscar.Location = new System.Drawing.Point(580, 113);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(89, 33);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::CpPizzeria.Properties.Resources.pizzaback;
            this.ClientSize = new System.Drawing.Size(730, 515);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dvgListaVenta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxProducto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenta";
            this.Text = "::: Ventas - Pizza :::";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgListaVenta)).EndInit();
            this.gbxProducto.ResumeLayout(false);
            this.gbxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadP)).EndInit();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxVenta.ResumeLayout(false);
            this.gbxVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpNit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dvgListaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgSubTotal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox tbxIdProducto;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.GroupBox gbxVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private Guna.UI2.WinForms.Guna2Button btnBuscar;
        private Guna.UI2.WinForms.Guna2Button btnAgregar;
        private Guna.UI2.WinForms.Guna2TextBox txtNit;
        private Guna.UI2.WinForms.Guna2TextBox txtrazonSocial;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2ComboBox CbxProducto;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudStock;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCantidadP;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2Button btnRegistrarVenta;
        private Guna.UI2.WinForms.Guna2Button btnVolver;
        private System.Windows.Forms.ErrorProvider erpNit;
        private System.Windows.Forms.ErrorProvider erpRazonSocial;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.ErrorProvider erpProducto;
    }
}