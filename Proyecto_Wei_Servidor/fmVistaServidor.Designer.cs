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
            this.dgtUsuariosConectados = new System.Windows.Forms.DataGridView();
            this.btnEnviarMsjServidor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioAdmin = new System.Windows.Forms.TextBox();
            this.txtPassAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalirServidor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtUsuariosConectados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarServidor
            // 
            this.btnIniciarServidor.Location = new System.Drawing.Point(31, 217);
            this.btnIniciarServidor.Name = "btnIniciarServidor";
            this.btnIniciarServidor.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarServidor.TabIndex = 0;
            this.btnIniciarServidor.Text = "Iniciar";
            this.btnIniciarServidor.UseVisualStyleBackColor = true;
            this.btnIniciarServidor.Click += new System.EventHandler(this.btnIniciarServidor_Click);
            // 
            // btnDetenerServidor
            // 
            this.btnDetenerServidor.Location = new System.Drawing.Point(131, 217);
            this.btnDetenerServidor.Name = "btnDetenerServidor";
            this.btnDetenerServidor.Size = new System.Drawing.Size(75, 23);
            this.btnDetenerServidor.TabIndex = 1;
            this.btnDetenerServidor.Text = "Detener";
            this.btnDetenerServidor.UseVisualStyleBackColor = true;
            this.btnDetenerServidor.Click += new System.EventHandler(this.btnDetenerServidor_Click);
            // 
            // btnLoginServidor
            // 
            this.btnLoginServidor.Location = new System.Drawing.Point(80, 128);
            this.btnLoginServidor.Name = "btnLoginServidor";
            this.btnLoginServidor.Size = new System.Drawing.Size(89, 37);
            this.btnLoginServidor.TabIndex = 2;
            this.btnLoginServidor.Text = "Iniciar Sesión";
            this.btnLoginServidor.UseVisualStyleBackColor = true;
            this.btnLoginServidor.Click += new System.EventHandler(this.btnLoginServidor_Click);
            // 
            // btnAprobarServidor
            // 
            this.btnAprobarServidor.Location = new System.Drawing.Point(657, 272);
            this.btnAprobarServidor.Name = "btnAprobarServidor";
            this.btnAprobarServidor.Size = new System.Drawing.Size(107, 37);
            this.btnAprobarServidor.TabIndex = 3;
            this.btnAprobarServidor.Text = "Aprobar conductores";
            this.btnAprobarServidor.UseVisualStyleBackColor = true;
            this.btnAprobarServidor.Click += new System.EventHandler(this.btnAprobarServidor_Click);
            // 
            // btnVerViajesServidor
            // 
            this.btnVerViajesServidor.Location = new System.Drawing.Point(515, 271);
            this.btnVerViajesServidor.Name = "btnVerViajesServidor";
            this.btnVerViajesServidor.Size = new System.Drawing.Size(107, 40);
            this.btnVerViajesServidor.TabIndex = 4;
            this.btnVerViajesServidor.Text = "Ver viajes en curso";
            this.btnVerViajesServidor.UseVisualStyleBackColor = true;
            // 
            // dgtUsuariosConectados
            // 
            this.dgtUsuariosConectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtUsuariosConectados.Location = new System.Drawing.Point(371, 52);
            this.dgtUsuariosConectados.Name = "dgtUsuariosConectados";
            this.dgtUsuariosConectados.Size = new System.Drawing.Size(393, 215);
            this.dgtUsuariosConectados.TabIndex = 5;
            // 
            // btnEnviarMsjServidor
            // 
            this.btnEnviarMsjServidor.Location = new System.Drawing.Point(371, 273);
            this.btnEnviarMsjServidor.Name = "btnEnviarMsjServidor";
            this.btnEnviarMsjServidor.Size = new System.Drawing.Size(100, 36);
            this.btnEnviarMsjServidor.TabIndex = 6;
            this.btnEnviarMsjServidor.Text = "Enviar mensaje";
            this.btnEnviarMsjServidor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña:";
            // 
            // txtUsuarioAdmin
            // 
            this.txtUsuarioAdmin.Location = new System.Drawing.Point(94, 52);
            this.txtUsuarioAdmin.Name = "txtUsuarioAdmin";
            this.txtUsuarioAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtUsuarioAdmin.TabIndex = 9;
            // 
            // txtPassAdmin
            // 
            this.txtPassAdmin.Location = new System.Drawing.Point(94, 89);
            this.txtPassAdmin.Name = "txtPassAdmin";
            this.txtPassAdmin.Size = new System.Drawing.Size(100, 20);
            this.txtPassAdmin.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Usuarios conectados:";
            // 
            // btnSalirServidor
            // 
            this.btnSalirServidor.Location = new System.Drawing.Point(13, 318);
            this.btnSalirServidor.Name = "btnSalirServidor";
            this.btnSalirServidor.Size = new System.Drawing.Size(75, 23);
            this.btnSalirServidor.TabIndex = 12;
            this.btnSalirServidor.Text = "Salir";
            this.btnSalirServidor.UseVisualStyleBackColor = true;
            this.btnSalirServidor.Click += new System.EventHandler(this.btnSalirServidor_Click);
            // 
            // fmVistaServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 353);
            this.Controls.Add(this.btnSalirServidor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassAdmin);
            this.Controls.Add(this.txtUsuarioAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviarMsjServidor);
            this.Controls.Add(this.dgtUsuariosConectados);
            this.Controls.Add(this.btnVerViajesServidor);
            this.Controls.Add(this.btnAprobarServidor);
            this.Controls.Add(this.btnLoginServidor);
            this.Controls.Add(this.btnDetenerServidor);
            this.Controls.Add(this.btnIniciarServidor);
            this.Name = "fmVistaServidor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmVistaServidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtUsuariosConectados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarServidor;
        private System.Windows.Forms.Button btnDetenerServidor;
        private System.Windows.Forms.Button btnLoginServidor;
        private System.Windows.Forms.Button btnAprobarServidor;
        private System.Windows.Forms.Button btnVerViajesServidor;
        private System.Windows.Forms.DataGridView dgtUsuariosConectados;
        private System.Windows.Forms.Button btnEnviarMsjServidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuarioAdmin;
        private System.Windows.Forms.TextBox txtPassAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalirServidor;
    }
}

