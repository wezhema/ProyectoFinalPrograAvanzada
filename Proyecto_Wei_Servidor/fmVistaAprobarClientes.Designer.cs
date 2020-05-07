namespace Proyecto_Wei_Servidor
{
    partial class fmVistaAprobarClientes
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
            this.dgtClientesSinAprobar = new System.Windows.Forms.DataGridView();
            this.btnAprobarCliente = new System.Windows.Forms.Button();
            this.btnDenegarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirAprobarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtClientesSinAprobar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtClientesSinAprobar
            // 
            this.dgtClientesSinAprobar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtClientesSinAprobar.Location = new System.Drawing.Point(13, 47);
            this.dgtClientesSinAprobar.Name = "dgtClientesSinAprobar";
            this.dgtClientesSinAprobar.Size = new System.Drawing.Size(775, 344);
            this.dgtClientesSinAprobar.TabIndex = 0;
            this.dgtClientesSinAprobar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtClientesSinAprobar_CellContentClick);
            // 
            // btnAprobarCliente
            // 
            this.btnAprobarCliente.Location = new System.Drawing.Point(13, 410);
            this.btnAprobarCliente.Name = "btnAprobarCliente";
            this.btnAprobarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAprobarCliente.TabIndex = 1;
            this.btnAprobarCliente.Text = "Aprobar";
            this.btnAprobarCliente.UseVisualStyleBackColor = true;
            // 
            // btnDenegarCliente
            // 
            this.btnDenegarCliente.Location = new System.Drawing.Point(105, 409);
            this.btnDenegarCliente.Name = "btnDenegarCliente";
            this.btnDenegarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnDenegarCliente.TabIndex = 2;
            this.btnDenegarCliente.Text = "Denegar";
            this.btnDenegarCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de clientes sin aprobar:";
            // 
            // btnSalirAprobarClientes
            // 
            this.btnSalirAprobarClientes.Location = new System.Drawing.Point(713, 409);
            this.btnSalirAprobarClientes.Name = "btnSalirAprobarClientes";
            this.btnSalirAprobarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirAprobarClientes.TabIndex = 4;
            this.btnSalirAprobarClientes.Text = "Salir";
            this.btnSalirAprobarClientes.UseVisualStyleBackColor = true;
            this.btnSalirAprobarClientes.Click += new System.EventHandler(this.btnSalirAprobarClientes_Click);
            // 
            // fmVistaAprobarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirAprobarClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDenegarCliente);
            this.Controls.Add(this.btnAprobarCliente);
            this.Controls.Add(this.dgtClientesSinAprobar);
            this.Name = "fmVistaAprobarClientes";
            this.Text = "fmVistaAprobarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgtClientesSinAprobar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtClientesSinAprobar;
        private System.Windows.Forms.Button btnAprobarCliente;
        private System.Windows.Forms.Button btnDenegarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirAprobarClientes;
    }
}