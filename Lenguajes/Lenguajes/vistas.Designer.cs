namespace Lenguajes
{
    partial class vistas
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
            this.BtnClientes = new System.Windows.Forms.Button();
            this.DgvVista = new System.Windows.Forms.DataGridView();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.btntipos = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(40, 379);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(75, 23);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // DgvVista
            // 
            this.DgvVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVista.Location = new System.Drawing.Point(30, 35);
            this.DgvVista.Name = "DgvVista";
            this.DgvVista.RowTemplate.Height = 24;
            this.DgvVista.Size = new System.Drawing.Size(727, 278);
            this.DgvVista.TabIndex = 1;
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.Location = new System.Drawing.Point(571, 379);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(75, 23);
            this.btnTarjetas.TabIndex = 2;
            this.btnTarjetas.Text = "tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = true;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click);
            // 
            // btntipos
            // 
            this.btntipos.Location = new System.Drawing.Point(349, 379);
            this.btntipos.Name = "btntipos";
            this.btntipos.Size = new System.Drawing.Size(140, 23);
            this.btntipos.TabIndex = 3;
            this.btntipos.Text = "tipo de cuentas";
            this.btntipos.UseVisualStyleBackColor = true;
            this.btntipos.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.Location = new System.Drawing.Point(192, 379);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(75, 23);
            this.btnCuentas.TabIndex = 4;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.button3_Click);
            // 
            // vistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.btntipos);
            this.Controls.Add(this.btnTarjetas);
            this.Controls.Add(this.DgvVista);
            this.Controls.Add(this.BtnClientes);
            this.Name = "vistas";
            this.Text = "vistas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.DataGridView DgvVista;
        private System.Windows.Forms.Button btnTarjetas;
        private System.Windows.Forms.Button btntipos;
        private System.Windows.Forms.Button btnCuentas;
    }
}