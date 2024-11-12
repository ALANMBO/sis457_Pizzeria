namespace CpPizzeria
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.lblRazon = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtRazon = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxLista = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.erpRazonsocial = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCedula = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpCelular = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxDatos.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.gbxLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonsocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.lblRazon);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.txtCelular);
            this.gbxDatos.Controls.Add(this.txtRazon);
            this.gbxDatos.Controls.Add(this.lblCelular);
            this.gbxDatos.Controls.Add(this.lblCedula);
            this.gbxDatos.Controls.Add(this.txtCedula);
            this.gbxDatos.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(6, 295);
            this.gbxDatos.Margin = new System.Windows.Forms.Padding(4);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Padding = new System.Windows.Forms.Padding(4);
            this.gbxDatos.Size = new System.Drawing.Size(565, 191);
            this.gbxDatos.TabIndex = 21;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Text = "Datos del Cliente ";
            this.gbxDatos.Enter += new System.EventHandler(this.gbxDatos_Enter);
            // 
            // lblRazon
            // 
            this.lblRazon.AutoSize = true;
            this.lblRazon.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblRazon.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazon.Location = new System.Drawing.Point(8, 33);
            this.lblRazon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazon.Name = "lblRazon";
            this.lblRazon.Size = new System.Drawing.Size(117, 19);
            this.lblRazon.TabIndex = 15;
            this.lblRazon.Text = "Razon Social:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(172, 132);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 37);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(133, 104);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(235, 20);
            this.txtCelular.TabIndex = 12;
            // 
            // txtRazon
            // 
            this.txtRazon.Location = new System.Drawing.Point(133, 32);
            this.txtRazon.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazon.Name = "txtRazon";
            this.txtRazon.Size = new System.Drawing.Size(235, 20);
            this.txtRazon.TabIndex = 7;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCelular.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(5, 102);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(75, 19);
            this.lblCelular.TabIndex = 11;
            this.lblCelular.Text = "Celular:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblCedula.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(5, 68);
            this.lblCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(45, 19);
            this.lblCedula.TabIndex = 9;
            this.lblCedula.Text = "NIT:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(133, 68);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(235, 20);
            this.txtCedula.TabIndex = 10;
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAcciones.Controls.Add(this.btnLimpiar);
            this.pnlAcciones.Controls.Add(this.btnEditar);
            this.pnlAcciones.Controls.Add(this.btnEliminar);
            this.pnlAcciones.Controls.Add(this.btnNuevo);
            this.pnlAcciones.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAcciones.Location = new System.Drawing.Point(593, 84);
            this.pnlAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(194, 378);
            this.pnlAcciones.TabIndex = 20;
            this.pnlAcciones.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAcciones_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.LightGray;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(17, 176);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 42);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.LightGray;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(17, 75);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 40);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(17, 123);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 45);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.LightGray;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(17, 38);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(94, 29);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxLista
            // 
            this.gbxLista.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxLista.Controls.Add(this.dgvLista);
            this.gbxLista.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLista.Location = new System.Drawing.Point(6, 84);
            this.gbxLista.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLista.Name = "gbxLista";
            this.gbxLista.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLista.Size = new System.Drawing.Size(579, 208);
            this.gbxLista.TabIndex = 19;
            this.gbxLista.TabStop = false;
            this.gbxLista.Text = "Clientes";
            this.gbxLista.Enter += new System.EventHandler(this.gbxLista_Enter);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Location = new System.Drawing.Point(8, 23);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersWidth = 51;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(557, 173);
            this.dgvLista.TabIndex = 0;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(522, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 41);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(138, 42);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(376, 20);
            this.txtBuscar.TabIndex = 17;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBuscar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(3, 43);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(127, 19);
            this.lblBuscar.TabIndex = 16;
            this.lblBuscar.Text = "Buscar Cliente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(800, 43);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // erpRazonsocial
            // 
            this.erpRazonsocial.ContainerControl = this;
            // 
            // erpCedula
            // 
            this.erpCedula.ContainerControl = this;
            // 
            // erpCelular
            // 
            this.erpCelular.ContainerControl = this;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.LightGray;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(706, 0);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 42);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CpPizzeria.Properties.Resources.descarga;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.gbxLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.Text = "::: Cliente - Pizza :::";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.gbxLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpRazonsocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCedula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpCelular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label lblRazon;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtRazon;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxLista;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider erpRazonsocial;
        private System.Windows.Forms.ErrorProvider erpCedula;
        private System.Windows.Forms.ErrorProvider erpCelular;
        private System.Windows.Forms.Button btnVolver;
    }
}