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
            this.SuspendLayout();
            // 
            // btnClientePrincipal
            // 
            this.btnClientePrincipal.Location = new System.Drawing.Point(64, 100);
            this.btnClientePrincipal.Name = "btnClientePrincipal";
            this.btnClientePrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnClientePrincipal.TabIndex = 0;
            this.btnClientePrincipal.Text = "Cliente";
            this.btnClientePrincipal.UseVisualStyleBackColor = true;
            this.btnClientePrincipal.Click += new System.EventHandler(this.btnClientePrincipal_Click);
            // 
            // btnServidorPrincipal
            // 
            this.btnServidorPrincipal.Location = new System.Drawing.Point(64, 53);
            this.btnServidorPrincipal.Name = "btnServidorPrincipal";
            this.btnServidorPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnServidorPrincipal.TabIndex = 1;
            this.btnServidorPrincipal.Text = "Servidor";
            this.btnServidorPrincipal.UseVisualStyleBackColor = true;
            this.btnServidorPrincipal.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalirPrincipal
            // 
            this.btnSalirPrincipal.Location = new System.Drawing.Point(64, 143);
            this.btnSalirPrincipal.Name = "btnSalirPrincipal";
            this.btnSalirPrincipal.Size = new System.Drawing.Size(75, 23);
            this.btnSalirPrincipal.TabIndex = 2;
            this.btnSalirPrincipal.Text = "Salir";
            this.btnSalirPrincipal.UseVisualStyleBackColor = true;
            this.btnSalirPrincipal.Click += new System.EventHandler(this.btnSalirPrincipal_Click);
            // 
            // fmVistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 233);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalirPrincipal);
            this.Controls.Add(this.btnServidorPrincipal);
            this.Controls.Add(this.btnClientePrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaPrincipal";
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.fmVistaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientePrincipal;
        private System.Windows.Forms.Button btnServidorPrincipal;
        private System.Windows.Forms.Button btnSalirPrincipal;
    }
}