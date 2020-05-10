namespace Proyecto_Wei_Servidor
{
    partial class fmVistaViajesEnCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvViajesEnCurso = new System.Windows.Forms.DataGridView();
            this.btnSalirViajesEnCurso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesEnCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viajes en curso:";
            // 
            // dgvViajesEnCurso
            // 
            this.dgvViajesEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesEnCurso.Location = new System.Drawing.Point(16, 47);
            this.dgvViajesEnCurso.Name = "dgvViajesEnCurso";
            this.dgvViajesEnCurso.Size = new System.Drawing.Size(761, 369);
            this.dgvViajesEnCurso.TabIndex = 1;
            this.dgvViajesEnCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSalirViajesEnCurso
            // 
            this.btnSalirViajesEnCurso.Location = new System.Drawing.Point(687, 436);
            this.btnSalirViajesEnCurso.Name = "btnSalirViajesEnCurso";
            this.btnSalirViajesEnCurso.Size = new System.Drawing.Size(75, 23);
            this.btnSalirViajesEnCurso.TabIndex = 2;
            this.btnSalirViajesEnCurso.Text = "Salir";
            this.btnSalirViajesEnCurso.UseVisualStyleBackColor = true;
            this.btnSalirViajesEnCurso.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmVistaViajesEnCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnSalirViajesEnCurso);
            this.Controls.Add(this.dgvViajesEnCurso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmVistaViajesEnCurso";
            this.Text = "Viajes en curso";
            this.Load += new System.EventHandler(this.fmVistaViajesEnCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesEnCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvViajesEnCurso;
        private System.Windows.Forms.Button btnSalirViajesEnCurso;
    }
}