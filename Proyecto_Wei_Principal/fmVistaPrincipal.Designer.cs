namespace Proyecto_Wei_Principal
{
    partial class fmVistaPrincipal
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
            this.btnClientePrincipal = new System.Windows.Forms.Button();
            this.btnServidorPrincipal = new System.Windows.Forms.Button();
            this.btnSalirPrincipal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnClientePrincipal
            // 
            this.btnClientePrincipal.Location = new System.Drawing.Point(67, 125);
            this.btnClientePrincipal.Name = "btnClientePrincipal";
            this.btnClientePrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnClientePrincipal.TabIndex = 0;
            this.btnClientePrincipal.Text = "Cliente";
            this.btnClientePrincipal.UseVisualStyleBackColor = true;
            this.btnClientePrincipal.Click += new System.EventHandler(this.btnClientePrincipal_Click);
            // 
            // btnServidorPrincipal
            // 
            this.btnServidorPrincipal.Location = new System.Drawing.Point(67, 78);
            this.btnServidorPrincipal.Name = "btnServidorPrincipal";
            this.btnServidorPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnServidorPrincipal.TabIndex = 1;
            this.btnServidorPrincipal.Text = "Servidor";
            this.btnServidorPrincipal.UseVisualStyleBackColor = true;
            this.btnServidorPrincipal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalirPrincipal
            // 
            this.btnSalirPrincipal.Location = new System.Drawing.Point(67, 168);
            this.btnSalirPrincipal.Name = "btnSalirPrincipal";
            this.btnSalirPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnSalirPrincipal.TabIndex = 2;
            this.btnSalirPrincipal.Text = "Salir";
            this.btnSalirPrincipal.UseVisualStyleBackColor = true;
            this.btnSalirPrincipal.Click += new System.EventHandler(this.btnSalirPrincipal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proyecto Final: Wei Le Zheng";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 177);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones:";
            // 
            // fmVistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 243);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirPrincipal);
            this.Controls.Add(this.btnServidorPrincipal);
            this.Controls.Add(this.btnClientePrincipal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.fmVistaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientePrincipal;
        private System.Windows.Forms.Button btnServidorPrincipal;
        private System.Windows.Forms.Button btnSalirPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}