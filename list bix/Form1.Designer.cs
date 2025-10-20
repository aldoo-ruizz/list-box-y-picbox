namespace list_bix
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
            this.lbanimales = new System.Windows.Forms.ListBox();
            this.pbanimales = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbanimales)).BeginInit();
            this.SuspendLayout();
            // 
            // lbanimales
            // 
            this.lbanimales.FormattingEnabled = true;
            this.lbanimales.Location = new System.Drawing.Point(147, 22);
            this.lbanimales.Name = "lbanimales";
            this.lbanimales.Size = new System.Drawing.Size(240, 121);
            this.lbanimales.TabIndex = 0;
            this.lbanimales.SelectedIndexChanged += new System.EventHandler(this.lbanimales_SelectedIndexChanged);
            // 
            // pbanimales
            // 
            this.pbanimales.Location = new System.Drawing.Point(146, 158);
            this.pbanimales.Name = "pbanimales";
            this.pbanimales.Size = new System.Drawing.Size(240, 119);
            this.pbanimales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbanimales.TabIndex = 1;
            this.pbanimales.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 330);
            this.Controls.Add(this.pbanimales);
            this.Controls.Add(this.lbanimales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbanimales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbanimales;
        private System.Windows.Forms.PictureBox pbanimales;
    }
}

