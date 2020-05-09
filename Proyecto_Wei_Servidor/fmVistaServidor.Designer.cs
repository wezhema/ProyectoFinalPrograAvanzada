namespace Proyecto_Wei_Servidor
{
    partial class fmVistaServidor
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
            this.btnIniciarServidor = new System.Windows.Forms.Button();
            this.btnDetenerServidor = new System.Windows.Forms.Button();
            this.btnLoginServidor = new System.Windows.Forms.Button();
            this.btnAprobarServidor = new System.Windows.Forms.Button();
            this.btnVerViajesServidor = new System.Windows.Forms.Button();
            this.btnEnviarMsjServidor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalirServidor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.lstUsuariosConectados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarServidor
            // 
            this.btnIniciarServidor.Location = new System.Drawing.Point(13, 78);
            this.btnIniciarServidor.Name = "btnIniciarServidor";
            this.btnIniciarServidor.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarServidor.TabIndex = 0;
            this.btnIniciarServidor.Text = "Iniciar";
            this.btnIniciarServidor.UseVisualStyleBackColor = true;
            this.btnIniciarServidor.Click += new System.EventHandler(this.btnIniciarServidor_Click);
            // 
            // btnDetenerServidor
            // 
            this.btnDetenerServidor.Location = new System.Drawing.Point(110, 78);
            this.btnDetenerServidor.Name = "btnDetenerServidor";
            this.btnDetenerServidor.Size = new System.Drawing.Size(75, 23);
            this.btnDetenerServidor.TabIndex = 1;
            this.btnDetenerServidor.Text = "Detener";
            this.btnDetenerServidor.UseVisualStyleBackColor = true;
            this.btnDetenerServidor.Click += new System.EventHandler(this.btnDetenerServidor_Click);
            // 
            // btnLoginServidor
            // 
            this.btnLoginServidor.Location = new System.Drawing.Point(69, 128);
            this.btnLoginServidor.Name = "btnLoginServidor";
            this.btnLoginServidor.Size = new System.Drawing.Size(100, 37);
            this.btnLoginServidor.TabIndex = 2;
            this.btnLoginServidor.Text = "Iniciar Sesión";
            this.btnLoginServidor.UseVisualStyleBackColor = true;
            this.btnLoginServidor.Click += new System.EventHandler(this.btnLoginServidor_Click);
            // 
            // btnAprobarServidor
            // 
            this.btnAprobarServidor.Location = new System.Drawing.Point(622, 284);
            this.btnAprobarServidor.Name = "btnAprobarServidor";
            this.btnAprobarServidor.Size = new System.Drawing.Size(107, 37);
            this.btnAprobarServidor.TabIndex = 3;
            this.btnAprobarServidor.Text = "Aprobar conductores";
            this.btnAprobarServidor.UseVisualStyleBackColor = true;
            this.btnAprobarServidor.Click += new System.EventHandler(this.btnAprobarServidor_Click);
            // 
            // btnVerViajesServidor
            // 
            this.btnVerViajesServidor.Location = new System.Drawing.Point(480, 283);
            this.btnVerViajesServidor.Name = "btnVerViajesServidor";
            this.btnVerViajesServidor.Size = new System.Drawing.Size(107, 40);
            this.btnVerViajesServidor.TabIndex = 4;
            this.btnVerViajesServidor.Text = "Ver viajes en curso";
            this.btnVerViajesServidor.UseVisualStyleBackColor = true;
            this.btnVerViajesServidor.Click += new System.EventHandler(this.btnVerViajesServidor_Click);
            // 
            // btnEnviarMsjServidor
            // 
            this.btnEnviarMsjServidor.Location = new System.Drawing.Point(336, 285);
            this.btnEnviarMsjServidor.Name = "btnEnviarMsjServidor";
            this.btnEnviarMsjServidor.Size = new System.Drawing.Size(100, 36);
            this.btnEnviarMsjServidor.TabIndex = 6;
            this.btnEnviarMsjServidor.Text = "Enviar mensaje";
            this.btnEnviarMsjServidor.UseVisualStyleBackColor = true;
            this.btnEnviarMsjServidor.Click += new System.EventHandler(this.btnEnviarMsjServidor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(69, 49);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioAdmin.TabIndex = 9;
            this.txtUsuarioAdmin.TextChanged += new System.EventHandler(this.txtUsuarioAdmin_TextChanged);
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(69, 88);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtPassAdmin.TabIndex = 10;
            this.txtPassAdmin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuarios conectados:";
            // 
            // btnSalirServidor
            // 
            this.btnSalirServidor.Location = new System.Drawing.Point(651, 337);
            this.btnSalirServidor.Name = "btnSalirServidor";
            this.btnSalirServidor.Size = new System.Drawing.Size(75, 23);
            this.btnSalirServidor.TabIndex = 12;
            this.btnSalirServidor.Text = "Salir";
            this.btnSalirServidor.UseVisualStyleBackColor = true;
            this.btnSalirServidor.Click += new System.EventHandler(this.btnSalirServidor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Servidor:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(65, 40);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(50, 13);
            this.lblServidor.TabIndex = 14;
            this.lblServidor.Text = "Detenido";
            // 
            // lstUsuariosConectados
            // 
            this.lstUsuariosConectados.FormattingEnabled = true;
            this.lstUsuariosConectados.Location = new System.Drawing.Point(336, 36);
            this.lstUsuariosConectados.Name = "lstUsuariosConectados";
            this.lstUsuariosConectados.Size = new System.Drawing.Size(390, 225);
            this.lstUsuariosConectados.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(27, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 188);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acceso al servidor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIniciarServidor);
            this.groupBox2.Controls.Add(this.lblServidor);
            this.groupBox2.Controls.Add(this.btnDetenerServidor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 125);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del servidor:";
            // 
            // fmVistaServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 388);
            this.ControlBox = false;
            this.Controls.Add(this.lstUsuariosConectados);
            this.Controls.Add(this.btnSalirServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.txtUsuarioAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarMsjServidor);
            this.Controls.Add(this.btnVerViajesServidor);
            this.Controls.Add(this.btnAprobarServidor);
            this.Controls.Add(this.btnLoginServidor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaServidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.fmVistaServidor_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarServidor;
        private System.Windows.Forms.Button btnDetenerServidor;
        private System.Windows.Forms.Button btnLoginServidor;
        private System.Windows.Forms.Button btnAprobarServidor;
        private System.Windows.Forms.Button btnVerViajesServidor;
        private System.Windows.Forms.Button btnEnviarMsjServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalirServidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.ListBox lstUsuariosConectados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

