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
            this.tbId_tipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizarLimit = new System.Windows.Forms.Button();
            this.tbLimite_new = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
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
            // tbId_tipo
            // 
            this.tbId_tipo.Location = new System.Drawing.Point(115, 116);
            this.tbId_tipo.Name = "tbId_tipo";
            this.tbId_tipo.Size = new System.Drawing.Size(100, 22);
            this.tbId_tipo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Actualizar limite";
            // 
            // BtnActualizarLimit
            // 
            this.BtnActualizarLimit.Location = new System.Drawing.Point(140, 204);
            this.BtnActualizarLimit.Name = "BtnActualizarLimit";
            this.BtnActualizarLimit.Size = new System.Drawing.Size(75, 23);
            this.BtnActualizarLimit.TabIndex = 3;
            this.BtnActualizarLimit.Text = "Actualizar";
            this.BtnActualizarLimit.UseVisualStyleBackColor = true;
            this.BtnActualizarLimit.Click += new System.EventHandler(this.BtnActualizarLimit_Click);
            // 
            // tbLimite_new
            // 
            this.tbLimite_new.Location = new System.Drawing.Point(115, 155);
            this.tbLimite_new.Name = "tbLimite_new";
            this.tbLimite_new.Size = new System.Drawing.Size(100, 22);
            this.tbLimite_new.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "limite nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLimite_new);
            this.Controls.Add(this.BtnActualizarLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId_tipo);
            this.Controls.Add(this.BtnConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox tbId_tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizarLimit;
        private System.Windows.Forms.TextBox tbLimite_new;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCliente;
    }
}

