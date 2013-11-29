namespace notchec
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTextoBeta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTextoBeta
            // 
            this.labelTextoBeta.AutoSize = true;
            this.labelTextoBeta.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextoBeta.Location = new System.Drawing.Point(34, 270);
            this.labelTextoBeta.Name = "labelTextoBeta";
            this.labelTextoBeta.Size = new System.Drawing.Size(51, 23);
            this.labelTextoBeta.TabIndex = 1;
            this.labelTextoBeta.Text = "label1";
            // 
            // button1
            // 
            this.button1.Image = global::notchec.Properties.Resources.beta;
            this.button1.Location = new System.Drawing.Point(93, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 219);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.clickImagen);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(444, 347);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextoBeta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextoBeta;
        private System.Windows.Forms.Button button1;
    }
}

