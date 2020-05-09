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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvViajeActivo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajeActivo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Location = new System.Drawing.Point(364, 189);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(75, 38);
            this.btnRegistrarCliente.TabIndex = 0;
            this.btnRegistrarCliente.Text = "Registrarse";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // btnLoginCliente
            // 
            this.btnLoginCliente.Location = new System.Drawing.Point(29, 189);
            this.btnLoginCliente.Name = "btnLoginCliente";
            this.btnLoginCliente.Size = new System.Drawing.Size(75, 38);
            this.btnLoginCliente.TabIndex = 1;
            this.btnLoginCliente.Text = "Iniciar Sesión";
            this.btnLoginCliente.UseVisualStyleBackColor = true;
            this.btnLoginCliente.Click += new System.EventHandler(this.btnLoginCliente_Click);
            // 
            // txtContraseniaCliente
            // 
            this.txtContraseniaCliente.Location = new System.Drawing.Point(29, 126);
            this.txtContraseniaCliente.Name = "txtContraseniaCliente";
            this.txtContraseniaCliente.Size = new System.Drawing.Size(156, 20);
            this.txtContraseniaCliente.TabIndex = 7;
            this.txtContraseniaCliente.UseSystemPasswordChar = true;
            // 
            // txtUsuarioCliente
            // 
            this.txtUsuarioCliente.Location = new System.Drawing.Point(29, 68);
            this.txtUsuarioCliente.Name = "txtUsuarioCliente";
            this.txtUsuarioCliente.Size = new System.Drawing.Size(156, 20);
            this.txtUsuarioCliente.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario:";
            // 
            // btnCrearViajeCliente
            // 
            this.btnCrearViajeCliente.Location = new System.Drawing.Point(364, 68);
            this.btnCrearViajeCliente.Name = "btnCrearViajeCliente";
            this.btnCrearViajeCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCrearViajeCliente.TabIndex = 8;
            this.btnCrearViajeCliente.Text = "Crear viaje";
            this.btnCrearViajeCliente.UseVisualStyleBackColor = true;
            this.btnCrearViajeCliente.Click += new System.EventHandler(this.btnCrearViajeCliente_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.Location = new System.Drawing.Point(364, 105);
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
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estado:";
            // 
            // lblEstadoCliente
            // 
            this.lblEstadoCliente.AutoSize = true;
            this.lblEstadoCliente.Location = new System.Drawing.Point(75, 159);
            this.lblEstadoCliente.Name = "lblEstadoCliente";
            this.lblEstadoCliente.Size = new System.Drawing.Size(77, 13);
            this.lblEstadoCliente.TabIndex = 11;
            this.lblEstadoCliente.Text = "Desconectado";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(110, 189);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(75, 38);
            this.btnDesconectar.TabIndex = 13;
            this.btnDesconectar.Text = "Cerrar Sesión";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViajeActivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 96);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viaje Activo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 251);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inicio de sesión:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvViajeActivo
            // 
            this.dgvViajeActivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajeActivo.Location = new System.Drawing.Point(7, 20);
            this.dgvViajeActivo.Name = "dgvViajeActivo";
            this.dgvViajeActivo.Size = new System.Drawing.Size(421, 70);
            this.dgvViajeActivo.TabIndex = 0;
            this.dgvViajeActivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajeActivo_CellContentClick);
            // 
            // fmVistaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 537);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblEstadoCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.btnCrearViajeCliente);
            this.Controls.Add(this.txtContraseniaCliente);
            this.Controls.Add(this.txtUsuarioCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoginCliente);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.fmVistaCliente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajeActivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

