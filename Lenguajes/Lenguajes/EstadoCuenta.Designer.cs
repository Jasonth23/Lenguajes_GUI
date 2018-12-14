namespace Lenguajes
{
    partial class EstadoCuenta
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
            this.DgvEstado = new System.Windows.Forms.DataGridView();
            this.tbEstado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstado)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEstado
            // 
            this.DgvEstado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstado.Location = new System.Drawing.Point(37, 25);
            this.DgvEstado.Name = "DgvEstado";
            this.DgvEstado.RowTemplate.Height = 24;
            this.DgvEstado.Size = new System.Drawing.Size(977, 319);
            this.DgvEstado.TabIndex = 0;
            // 
            // tbEstado
            // 
            this.tbEstado.Location = new System.Drawing.Point(144, 375);
            this.tbEstado.Name = "tbEstado";
            this.tbEstado.Size = new System.Drawing.Size(100, 22);
            this.tbEstado.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(37, 375);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(86, 17);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "id de cuenta";
            // 
            // EstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 513);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbEstado);
            this.Controls.Add(this.DgvEstado);
            this.Name = "EstadoCuenta";
            this.Text = "EstadoCuenta";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstado;
        private System.Windows.Forms.TextBox tbEstado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEstado;
    }
}