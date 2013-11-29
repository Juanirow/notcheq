namespace notchec
{
    partial class MovimientoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovimientoForm));
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxConcepto = new System.Windows.Forms.TextBox();
            this.labelConcepto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCosto = new System.Windows.Forms.Label();
            this.textBoxCosto = new System.Windows.Forms.TextBox();
            this.textBoxImporte = new System.Windows.Forms.TextBox();
            this.labelImporte = new System.Windows.Forms.Label();
            this.labelerrorConcepto = new System.Windows.Forms.Label();
            this.labelErrorCantidad = new System.Windows.Forms.Label();
            this.labelErrorCosto = new System.Windows.Forms.Label();
            this.labelerrorId = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.labelMensajeElimina = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(217, 32);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(253, 29);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 26);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxConcepto
            // 
            this.textBoxConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConcepto.Location = new System.Drawing.Point(110, 152);
            this.textBoxConcepto.MaxLength = 50;
            this.textBoxConcepto.Name = "textBoxConcepto";
            this.textBoxConcepto.Size = new System.Drawing.Size(280, 26);
            this.textBoxConcepto.TabIndex = 3;
            // 
            // labelConcepto
            // 
            this.labelConcepto.AutoSize = true;
            this.labelConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConcepto.Location = new System.Drawing.Point(26, 155);
            this.labelConcepto.Name = "labelConcepto";
            this.labelConcepto.Size = new System.Drawing.Size(78, 20);
            this.labelConcepto.TabIndex = 2;
            this.labelConcepto.Text = "Concepto";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.Location = new System.Drawing.Point(26, 220);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(81, 20);
            this.labelCantidad.TabIndex = 4;
            this.labelCantidad.Text = "Cantidad: ";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(110, 217);
            this.textBoxCantidad.MaxLength = 10;
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(116, 26);
            this.textBoxCantidad.TabIndex = 5;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.CambioTexto);
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCosto.Location = new System.Drawing.Point(26, 275);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(84, 20);
            this.labelCosto.TabIndex = 6;
            this.labelCosto.Text = "Costo:     $";
            // 
            // textBoxCosto
            // 
            this.textBoxCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCosto.Location = new System.Drawing.Point(110, 272);
            this.textBoxCosto.MaxLength = 10;
            this.textBoxCosto.Name = "textBoxCosto";
            this.textBoxCosto.Size = new System.Drawing.Size(116, 26);
            this.textBoxCosto.TabIndex = 7;
            this.textBoxCosto.TextChanged += new System.EventHandler(this.CambioTexto);
            // 
            // textBoxImporte
            // 
            this.textBoxImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporte.Location = new System.Drawing.Point(110, 318);
            this.textBoxImporte.Name = "textBoxImporte";
            this.textBoxImporte.ReadOnly = true;
            this.textBoxImporte.Size = new System.Drawing.Size(116, 26);
            this.textBoxImporte.TabIndex = 9;
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImporte.Location = new System.Drawing.Point(26, 321);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(85, 20);
            this.labelImporte.TabIndex = 8;
            this.labelImporte.Text = "Importe:  $";
            // 
            // labelerrorConcepto
            // 
            this.labelerrorConcepto.AutoSize = true;
            this.labelerrorConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerrorConcepto.ForeColor = System.Drawing.Color.Red;
            this.labelerrorConcepto.Location = new System.Drawing.Point(396, 158);
            this.labelerrorConcepto.Name = "labelerrorConcepto";
            this.labelerrorConcepto.Size = new System.Drawing.Size(15, 20);
            this.labelerrorConcepto.TabIndex = 10;
            this.labelerrorConcepto.Text = "*";
            // 
            // labelErrorCantidad
            // 
            this.labelErrorCantidad.AutoSize = true;
            this.labelErrorCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCantidad.Location = new System.Drawing.Point(232, 223);
            this.labelErrorCantidad.Name = "labelErrorCantidad";
            this.labelErrorCantidad.Size = new System.Drawing.Size(15, 20);
            this.labelErrorCantidad.TabIndex = 11;
            this.labelErrorCantidad.Text = "*";
            // 
            // labelErrorCosto
            // 
            this.labelErrorCosto.AutoSize = true;
            this.labelErrorCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCosto.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCosto.Location = new System.Drawing.Point(232, 278);
            this.labelErrorCosto.Name = "labelErrorCosto";
            this.labelErrorCosto.Size = new System.Drawing.Size(15, 20);
            this.labelErrorCosto.TabIndex = 12;
            this.labelErrorCosto.Text = "*";
            // 
            // labelerrorId
            // 
            this.labelerrorId.AutoSize = true;
            this.labelerrorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerrorId.ForeColor = System.Drawing.Color.Red;
            this.labelerrorId.Location = new System.Drawing.Point(359, 35);
            this.labelerrorId.Name = "labelerrorId";
            this.labelerrorId.Size = new System.Drawing.Size(15, 20);
            this.labelerrorId.TabIndex = 13;
            this.labelerrorId.Text = "*";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.Location = new System.Drawing.Point(351, 358);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(89, 34);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.clickOk);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(256, 358);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(89, 34);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::notchec.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(380, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 38);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.clickBuscar);
            // 
            // btnImagen
            // 
            this.btnImagen.Image = global::notchec.Properties.Resources.notas;
            this.btnImagen.Location = new System.Drawing.Point(12, 12);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(98, 121);
            this.btnImagen.TabIndex = 16;
            this.btnImagen.Text = "Nueva";
            this.btnImagen.UseVisualStyleBackColor = true;
            // 
            // labelMensajeElimina
            // 
            this.labelMensajeElimina.AutoSize = true;
            this.labelMensajeElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensajeElimina.ForeColor = System.Drawing.Color.Red;
            this.labelMensajeElimina.Location = new System.Drawing.Point(149, 101);
            this.labelMensajeElimina.Name = "labelMensajeElimina";
            this.labelMensajeElimina.Size = new System.Drawing.Size(204, 20);
            this.labelMensajeElimina.TabIndex = 18;
            this.labelMensajeElimina.Text = "pulse Aceptar Para Eliminar";
            // 
            // MovimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(445, 405);
            this.Controls.Add(this.labelMensajeElimina);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.labelerrorId);
            this.Controls.Add(this.labelErrorCosto);
            this.Controls.Add(this.labelErrorCantidad);
            this.Controls.Add(this.labelerrorConcepto);
            this.Controls.Add(this.textBoxImporte);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.textBoxCosto);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.textBoxConcepto);
            this.Controls.Add(this.labelConcepto);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovimientoForm";
            this.Text = "MovimientoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxConcepto;
        private System.Windows.Forms.Label labelConcepto;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.TextBox textBoxCosto;
        private System.Windows.Forms.TextBox textBoxImporte;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.Label labelerrorConcepto;
        private System.Windows.Forms.Label labelErrorCantidad;
        private System.Windows.Forms.Label labelErrorCosto;
        private System.Windows.Forms.Label labelerrorId;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelMensajeElimina;
    }
}