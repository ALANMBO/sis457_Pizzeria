namespace CpPizzeria
{
    partial class FrmAutenticacion
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
            this.lblSis324 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblclave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.erpUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpClave = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSis324
            // 
            this.lblSis324.AutoSize = true;
            this.lblSis324.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblSis324.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSis324.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSis324.Location = new System.Drawing.Point(124, 304);
            this.lblSis324.Name = "lblSis324";
            this.lblSis324.Size = new System.Drawing.Size(125, 42);
            this.lblSis324.TabIndex = 41;
            this.lblSis324.Text = "SIS-324";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(425, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 2);
            this.panel1.TabIndex = 40;
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Black;
            this.pnlUsuario.Location = new System.Drawing.Point(425, 203);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(251, 2);
            this.pnlUsuario.TabIndex = 39;
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(130, 104);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(175, 234);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 38;
            this.pctLogo.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.Transparent;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciar.Location = new System.Drawing.Point(411, 289);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(208, 35);
            this.btnIniciar.TabIndex = 37;
            this.btnIniciar.Text = "INICIAR SESION";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.UseVisualStyleBackColor = false;
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclave.Location = new System.Drawing.Point(311, 243);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(146, 28);
            this.lblclave.TabIndex = 36;
            this.lblclave.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(328, 183);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(103, 28);
            this.lblUsuario.TabIndex = 35;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.LightGray;
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(453, 244);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(223, 18);
            this.txtClave.TabIndex = 34;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.LightGray;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(453, 187);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(220, 18);
            this.txtUsuario.TabIndex = 33;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(428, 113);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 42);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "INICIAR SESIÒN";
            // 
            // erpUsuario
            // 
            this.erpUsuario.ContainerControl = this;
            // 
            // erpClave
            // 
            this.erpClave.ContainerControl = this;
            // 
            // FrmAutenticacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSis324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblclave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAutenticacion";
            this.Text = "FrmAutenticacion";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSis324;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblclave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider erpUsuario;
        private System.Windows.Forms.ErrorProvider erpClave;
    }
}