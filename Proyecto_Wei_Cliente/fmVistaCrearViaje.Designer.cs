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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIDConductor = new System.Windows.Forms.TextBox();
            this.txtIDViaje = new System.Windows.Forms.TextBox();
            this.txtPtoPartida = new System.Windows.Forms.TextBox();
            this.txtPtoDestino = new System.Windows.Forms.TextBox();
            this.btnRegistrarViaje = new System.Windows.Forms.Button();
            this.btnSalirViaje = new System.Windows.Forms.Button();
            this.txtDescCliente = new System.Windows.Forms.TextBox();
            this.txtTiempoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(345, 77);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(184, 13);
            label5.TabIndex = 12;
            label5.Text = "Descripción de la carga a transportar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Conductor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Viaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Punto de partida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Punto de destino:";
            // 
            // txtIDConductor
            // 
            this.txtIDConductor.Location = new System.Drawing.Point(42, 55);
            this.txtIDConductor.Name = "txtIDConductor";
            this.txtIDConductor.Size = new System.Drawing.Size(100, 20);
            this.txtIDConductor.TabIndex = 4;
            // 
            // txtIDViaje
            // 
            this.txtIDViaje.Location = new System.Drawing.Point(165, 55);
            this.txtIDViaje.Name = "txtIDViaje";
            this.txtIDViaje.Size = new System.Drawing.Size(100, 20);
            this.txtIDViaje.TabIndex = 5;
            // 
            // txtPtoPartida
            // 
            this.txtPtoPartida.Location = new System.Drawing.Point(42, 117);
            this.txtPtoPartida.Name = "txtPtoPartida";
            this.txtPtoPartida.Size = new System.Drawing.Size(100, 20);
            this.txtPtoPartida.TabIndex = 6;
            // 
            // txtPtoDestino
            // 
            this.txtPtoDestino.Location = new System.Drawing.Point(165, 117);
            this.txtPtoDestino.Name = "txtPtoDestino";
            this.txtPtoDestino.Size = new System.Drawing.Size(100, 20);
            this.txtPtoDestino.TabIndex = 7;
            // 
            // btnRegistrarViaje
            // 
            this.btnRegistrarViaje.Location = new System.Drawing.Point(67, 226);
            this.btnRegistrarViaje.Name = "btnRegistrarViaje";
            this.btnRegistrarViaje.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarViaje.TabIndex = 8;
            this.btnRegistrarViaje.Text = "Registrar";
            this.btnRegistrarViaje.UseVisualStyleBackColor = true;
            // 
            // btnSalirViaje
            // 
            this.btnSalirViaje.Location = new System.Drawing.Point(162, 226);
            this.btnSalirViaje.Name = "btnSalirViaje";
            this.btnSalirViaje.Size = new System.Drawing.Size(75, 23);
            this.btnSalirViaje.TabIndex = 9;
            this.btnSalirViaje.Text = "Salir";
            this.btnSalirViaje.UseVisualStyleBackColor = true;
            this.btnSalirViaje.Click += new System.EventHandler(this.btnSalirViaje_Click);
            // 
            // txtDescCliente
            // 
            this.txtDescCliente.Location = new System.Drawing.Point(348, 94);
            this.txtDescCliente.Name = "txtDescCliente";
            this.txtDescCliente.Size = new System.Drawing.Size(100, 20);
            this.txtDescCliente.TabIndex = 10;
            // 
            // txtTiempoCliente
            // 
            this.txtTiempoCliente.Location = new System.Drawing.Point(42, 167);
            this.txtTiempoCliente.Name = "txtTiempoCliente";
            this.txtTiempoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoCliente.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tiempo estimado:";
            // 
            // fmVistaCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 334);
            this.Controls.Add(this.label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtTiempoCliente);
            this.Controls.Add(this.txtDescCliente);
            this.Controls.Add(this.btnSalirViaje);
            this.Controls.Add(this.btnRegistrarViaje);
            this.Controls.Add(this.txtPtoDestino);
            this.Controls.Add(this.txtPtoPartida);
            this.Controls.Add(this.txtIDViaje);
            this.Controls.Add(this.txtIDConductor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmVistaCrearViaje";
            this.Text = "fmVistaCrearViaje";
            this.Load += new System.EventHandler(this.fmVistaCrearViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDConductor;
        private System.Windows.Forms.TextBox txtIDViaje;
        private System.Windows.Forms.TextBox txtPtoPartida;
        private System.Windows.Forms.TextBox txtPtoDestino;
        private System.Windows.Forms.Button btnRegistrarViaje;
        private System.Windows.Forms.Button btnSalirViaje;
        private System.Windows.Forms.TextBox txtDescCliente;
        private System.Windows.Forms.TextBox txtTiempoCliente;
        private System.Windows.Forms.Label label6;
    }
}