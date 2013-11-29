namespace notchec
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.labelNota = new System.Windows.Forms.Label();
            this.labelCheque = new System.Windows.Forms.Label();
            this.labelConfiguracion = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnCheques = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota.Location = new System.Drawing.Point(168, 77);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(66, 25);
            this.labelNota.TabIndex = 1;
            this.labelNota.Text = "Notas";
            // 
            // labelCheque
            // 
            this.labelCheque.AutoSize = true;
            this.labelCheque.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheque.Location = new System.Drawing.Point(168, 211);
            this.labelCheque.Name = "labelCheque";
            this.labelCheque.Size = new System.Drawing.Size(90, 25);
            this.labelCheque.TabIndex = 4;
            this.labelCheque.Text = "Cheques";
            // 
            // labelConfiguracion
            // 
            this.labelConfiguracion.AutoSize = true;
            this.labelConfiguracion.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfiguracion.Location = new System.Drawing.Point(168, 345);
            this.labelConfiguracion.Name = "labelConfiguracion";
            this.labelConfiguracion.Size = new System.Drawing.Size(150, 25);
            this.labelConfiguracion.TabIndex = 5;
            this.labelConfiguracion.Text = "Configuracion";
            // 
            // btnAyuda
            // 
            this.btnAyuda.AccessibleName = "Ayuda";
            this.btnAyuda.Image = global::notchec.Properties.Resources.help1;
            this.btnAyuda.Location = new System.Drawing.Point(310, 390);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(39, 39);
            this.btnAyuda.TabIndex = 6;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.clickOpcion);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.AccessibleName = "Configuracion";
            this.btnConfiguracion.Image = global::notchec.Properties.Resources.confImpresora;
            this.btnConfiguracion.Location = new System.Drawing.Point(26, 298);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(98, 116);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.clickOpcion);
            // 
            // btnCheques
            // 
            this.btnCheques.AccessibleName = "Cheques";
            this.btnCheques.Image = global::notchec.Properties.Resources.cheques;
            this.btnCheques.Location = new System.Drawing.Point(26, 164);
            this.btnCheques.Name = "btnCheques";
            this.btnCheques.Size = new System.Drawing.Size(98, 116);
            this.btnCheques.TabIndex = 2;
            this.btnCheques.UseVisualStyleBackColor = true;
            this.btnCheques.Click += new System.EventHandler(this.clickOpcion);
            // 
            // btnNotas
            // 
            this.btnNotas.AccessibleName = "Notas";
            this.btnNotas.Image = global::notchec.Properties.Resources.notas;
            this.btnNotas.Location = new System.Drawing.Point(26, 30);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(98, 116);
            this.btnNotas.TabIndex = 0;
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.clickOpcion);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(366, 441);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.labelConfiguracion);
            this.Controls.Add(this.labelCheque);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnCheques);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.btnNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.Button btnCheques;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Label labelCheque;
        private System.Windows.Forms.Label labelConfiguracion;
        private System.Windows.Forms.Button btnAyuda;
    }
}