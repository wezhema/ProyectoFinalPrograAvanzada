namespace Proyecto_Wei_Cliente
{
    partial class fmVistaCrearViaje
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
            System.Windows.Forms.Label label5;
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPtoPartida = new System.Windows.Forms.TextBox();
            this.txtPtoDestino = new System.Windows.Forms.TextBox();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.btnSalirViaje = new System.Windows.Forms.Button();
            this.txtDescCliente = new System.Windows.Forms.TextBox();
            this.txtTiempoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbIDConductor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(320, 105);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 13);
            label5.TabIndex = 12;
            label5.Text = "Descripción de la carga a transportar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Conductor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punto de partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punto de destino:";
            // 
            // txtPtoPartida
            // 
            this.txtPtoPartida.Location = new System.Drawing.Point(188, 55);
            this.txtPtoPartida.Name = "txtPtoPartida";
            this.txtPtoPartida.Size = new System.Drawing.Size(100, 20);
            this.txtPtoPartida.TabIndex = 6;
            // 
            // txtPtoDestino
            // 
            this.txtPtoDestino.Location = new System.Drawing.Point(188, 122);
            this.txtPtoDestino.Name = "txtPtoDestino";
            this.txtPtoDestino.Size = new System.Drawing.Size(100, 20);
            this.txtPtoDestino.TabIndex = 7;
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(176, 182);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarViaje.TabIndex = 8;
            this.btnRegistrarViaje.Text = "Registrar";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            this.btnRegistrarViaje.Click += new System.EventHandler(this.btnRegistrarViaje_Click);
            // 
            // btnSalirViaje
            // 
            this.btnSalirViaje.Location = new System.Drawing.Point(273, 182);
            this.btnSalirViaje.Name = "btnSalirViaje";
            this.btnSalirViaje.Size = new System.Drawing.Size(75, 23);
            this.btnSalirViaje.TabIndex = 9;
            this.btnSalirViaje.Text = "Salir";
            this.btnSalirViaje.UseVisualStyleBackColor = true;
            this.btnSalirViaje.Click += new System.EventHandler(this.btnSalirViaje_Click);
            // 
            // txtDescCliente
            // 
            this.txtDescCliente.Location = new System.Drawing.Point(323, 122);
            this.txtDescCliente.Name = "txtDescCliente";
            this.txtDescCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDescCliente.TabIndex = 10;
            // 
            // txtTiempoCliente
            // 
            this.txtTiempoCliente.Location = new System.Drawing.Point(54, 121);
            this.txtTiempoCliente.Name = "txtTiempoCliente";
            this.txtTiempoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoCliente.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiempo estimado:";
            // 
            // cmbIDConductor
            // 
            this.cmbIDConductor.FormattingEnabled = true;
            this.cmbIDConductor.Location = new System.Drawing.Point(54, 55);
            this.cmbIDConductor.Name = "cmbIDConductor";
            this.cmbIDConductor.Size = new System.Drawing.Size(100, 21);
            this.cmbIDConductor.TabIndex = 14;
            this.cmbIDConductor.SelectedIndexChanged += new System.EventHandler(this.cmbIDConductor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(323, 55);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 16;
            this.txtEstado.Text = "EN CURSO";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 163);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los siguientes datos:";
            // 
            // fmVistaCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 231);
            this.ControlBox = false;
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIDConductor);
            this.Controls.Add(this.label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtTiempoCliente);
            this.Controls.Add(this.txtDescCliente);
            this.Controls.Add(this.btnSalirViaje);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.txtPtoDestino);
            this.Controls.Add(this.txtPtoPartida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaCrearViaje";
            this.Text = "Crear Viaje";
            this.Load += new System.EventHandler(this.fmVistaCrearViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPtoPartida;
        private System.Windows.Forms.TextBox txtPtoDestino;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.Button btnSalirViaje;
        private System.Windows.Forms.TextBox txtDescCliente;
        private System.Windows.Forms.TextBox txtTiempoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbIDConductor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}