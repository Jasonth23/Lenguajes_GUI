namespace Lenguajes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnConectar = new System.Windows.Forms.Button();
            this.BtnActualizarLimit = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.BtnEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(377, 186);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 23);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Vistas";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // BtnActualizarLimit
            // 
            this.BtnActualizarLimit.Location = new System.Drawing.Point(348, 110);
            this.BtnActualizarLimit.Name = "BtnActualizarLimit";
            this.BtnActualizarLimit.Size = new System.Drawing.Size(140, 23);
            this.BtnActualizarLimit.TabIndex = 3;
            this.BtnActualizarLimit.Text = "Tipo de cuenta";
            this.BtnActualizarLimit.UseVisualStyleBackColor = true;
            this.BtnActualizarLimit.Click += new System.EventHandler(this.BtnActualizarLimit_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(377, 275);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // BtnEstado
            // 
            this.BtnEstado.Location = new System.Drawing.Point(377, 350);
            this.BtnEstado.Name = "BtnEstado";
            this.BtnEstado.Size = new System.Drawing.Size(75, 23);
            this.BtnEstado.TabIndex = 8;
            this.BtnEstado.Text = "Estado de cuenta";
            this.BtnEstado.UseVisualStyleBackColor = true;
            this.BtnEstado.Click += new System.EventHandler(this.BtnEstado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnEstado);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.BtnActualizarLimit);
            this.Controls.Add(this.BtnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Button BtnActualizarLimit;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button BtnEstado;
    }
}

