namespace U4_CSharp
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
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnAvion = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(207, 73);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(124, 58);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnAvion
            // 
            this.btnAvion.Location = new System.Drawing.Point(388, 73);
            this.btnAvion.Name = "btnAvion";
            this.btnAvion.Size = new System.Drawing.Size(109, 58);
            this.btnAvion.TabIndex = 1;
            this.btnAvion.Text = "Avión";
            this.btnAvion.UseVisualStyleBackColor = true;
            this.btnAvion.Click += new System.EventHandler(this.btnAvion_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.Location = new System.Drawing.Point(177, 226);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(385, 198);
            this.lblFinal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.btnAvion);
            this.Controls.Add(this.btnCarro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnAvion;
        private System.Windows.Forms.Label lblFinal;
    }
}

