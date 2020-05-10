namespace Proyecto_Wei_Cliente
{
    partial class fmVistaCliente
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
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.btnLoginCliente = new System.Windows.Forms.Button();
            this.txtContraseniaCliente = new System.Windows.Forms.TextBox();
            this.txtUsuarioCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearViajeCliente = new System.Windows.Forms.Button();
            this.btnSalirCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstadoCliente = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnFinalizarViaje = new System.Windows.Forms.Button();
            this.dgvViajeActivo = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajeActivo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(280, 177);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(75, 38);
            this.btnRegistrarCliente.TabIndex = 0;
            this.btnRegistrarCliente.Text = "Registrarse";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnLoginCliente
            // 
            this.btnLoginCliente.Location = new System.Drawing.Point(74, 177);
            this.btnLoginCliente.Name = "btnLoginCliente";
            this.btnLoginCliente.Size = new System.Drawing.Size(75, 38);
            this.btnLoginCliente.TabIndex = 1;
            this.btnLoginCliente.Text = "Iniciar Sesión";
            this.btnLoginCliente.UseVisualStyleBackColor = true;
            this.btnLoginCliente.Click += new System.EventHandler(this.btnLoginCliente_Click);
            // 
            // txtContraseniaCliente
            // 
            this.txtContraseniaCliente.Location = new System.Drawing.Point(137, 101);
            this.txtContraseniaCliente.MaxLength = 50;
            this.txtContraseniaCliente.Name = "txtContraseniaCliente";
            this.txtContraseniaCliente.Size = new System.Drawing.Size(156, 20);
            this.txtContraseniaCliente.TabIndex = 7;
            this.txtContraseniaCliente.UseSystemPasswordChar = true;
            // 
            // txtUsuarioCliente
            // 
            this.txtUsuarioCliente.Location = new System.Drawing.Point(137, 43);
            this.txtUsuarioCliente.MaxLength = 50;
            this.txtUsuarioCliente.Name = "txtUsuarioCliente";
            this.txtUsuarioCliente.Size = new System.Drawing.Size(156, 20);
            this.txtUsuarioCliente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // btnCrearViajeCliente
            // 
            this.btnCrearViajeCliente.Location = new System.Drawing.Point(95, 135);
            this.btnCrearViajeCliente.Name = "btnCrearViajeCliente";
            this.btnCrearViajeCliente.Size = new System.Drawing.Size(85, 27);
            this.btnCrearViajeCliente.TabIndex = 8;
            this.btnCrearViajeCliente.Text = "Crear viaje";
            this.btnCrearViajeCliente.UseVisualStyleBackColor = true;
            this.btnCrearViajeCliente.Click += new System.EventHandler(this.btnCrearViajeCliente_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.Location = new System.Drawing.Point(379, 443);
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCliente.TabIndex = 9;
            this.btnSalirCliente.Text = "Salir";
            this.btnSalirCliente.UseVisualStyleBackColor = true;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estado:";
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Location = new System.Drawing.Point(204, 136);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(77, 13);
            this.lblEstadoCliente.TabIndex = 11;
            this.lblEstadoCliente.Text = "Desconectado";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(179, 177);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(75, 38);
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.Text = "Cerrar Sesión";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefrescar);
            this.groupBox1.Controls.Add(this.btnFinalizarViaje);
            this.groupBox1.Controls.Add(this.dgvViajeActivo);
            this.groupBox1.Controls.Add(this.btnCrearViajeCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 168);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viaje Activo:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(20, 28);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnFinalizarViaje
            // 
            this.btnFinalizarViaje.Location = new System.Drawing.Point(245, 135);
            this.btnFinalizarViaje.Name = "btnFinalizarViaje";
            this.btnFinalizarViaje.Size = new System.Drawing.Size(85, 27);
            this.btnFinalizarViaje.TabIndex = 9;
            this.btnFinalizarViaje.Text = "Finalizar viaje";
            this.btnFinalizarViaje.UseVisualStyleBackColor = true;
            this.btnFinalizarViaje.Click += new System.EventHandler(this.btnFinalizarViaje_Click);
            // 
            // dgvViajeActivo
            // 
            this.dgvViajeActivo.AllowUserToAddRows = false;
            this.dgvViajeActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajeActivo.Location = new System.Drawing.Point(20, 57);
            this.dgvViajeActivo.Name = "dgvViajeActivo";
            this.dgvViajeActivo.Size = new System.Drawing.Size(404, 72);
            this.dgvViajeActivo.TabIndex = 0;
            this.dgvViajeActivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajeActivo_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrarCliente);
            this.groupBox2.Controls.Add(this.lblEstadoCliente);
            this.groupBox2.Controls.Add(this.btnDesconectar);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtContraseniaCliente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLoginCliente);
            this.groupBox2.Controls.Add(this.txtUsuarioCliente);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 251);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inicio de sesión:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // fmVistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 478);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.fmVistaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajeActivo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Button btnLoginCliente;
        private System.Windows.Forms.TextBox txtContraseniaCliente;
        private System.Windows.Forms.TextBox txtUsuarioCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearViajeCliente;
        private System.Windows.Forms.Button btnSalirCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstadoCliente;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvViajeActivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFinalizarViaje;
        private System.Windows.Forms.Button btnRefrescar;
    }
}

