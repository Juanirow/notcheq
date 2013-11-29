namespace notchec
{
    partial class AltaBajasModifForm
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelElimina = new System.Windows.Forms.Label();
            this.labelErrorId = new System.Windows.Forms.Label();
            this.labelErrorNombre = new System.Windows.Forms.Label();
            this.labelErrorDireccion = new System.Windows.Forms.Label();
            this.labelErrorCiudad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(15, 49);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(102, 44);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombre.MaxLength = 50;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(168, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(102, 89);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDireccion.MaxLength = 50;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(168, 26);
            this.textBoxDireccion.TabIndex = 3;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(15, 132);
            this.labelCiudad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(63, 20);
            this.labelCiudad.TabIndex = 2;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(102, 132);
            this.textBoxCiudad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCiudad.MaxLength = 50;
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(168, 26);
            this.textBoxCiudad.TabIndex = 5;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(15, 89);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(79, 20);
            this.labelDireccion.TabIndex = 4;
            this.labelDireccion.Text = "Direccion:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(341, 172);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 42);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.clickAceptar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(29, 172);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(347, 38);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxId.MaxLength = 4;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(42, 26);
            this.textBoxId.TabIndex = 10;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(311, 44);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(28, 20);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "iD:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::notchec.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(418, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 36);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.buscaId);
            // 
            // labelElimina
            // 
            this.labelElimina.AutoSize = true;
            this.labelElimina.ForeColor = System.Drawing.Color.Red;
            this.labelElimina.Location = new System.Drawing.Point(311, 106);
            this.labelElimina.Name = "labelElimina";
            this.labelElimina.Size = new System.Drawing.Size(0, 20);
            this.labelElimina.TabIndex = 11;
            // 
            // labelErrorId
            // 
            this.labelErrorId.AutoSize = true;
            this.labelErrorId.ForeColor = System.Drawing.Color.Red;
            this.labelErrorId.Location = new System.Drawing.Point(396, 38);
            this.labelErrorId.Name = "labelErrorId";
            this.labelErrorId.Size = new System.Drawing.Size(15, 20);
            this.labelErrorId.TabIndex = 12;
            this.labelErrorId.Text = "*";
            // 
            // labelErrorNombre
            // 
            this.labelErrorNombre.AutoSize = true;
            this.labelErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.labelErrorNombre.Location = new System.Drawing.Point(277, 50);
            this.labelErrorNombre.Name = "labelErrorNombre";
            this.labelErrorNombre.Size = new System.Drawing.Size(15, 20);
            this.labelErrorNombre.TabIndex = 13;
            this.labelErrorNombre.Text = "*";
            // 
            // labelErrorDireccion
            // 
            this.labelErrorDireccion.AutoSize = true;
            this.labelErrorDireccion.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDireccion.Location = new System.Drawing.Point(277, 92);
            this.labelErrorDireccion.Name = "labelErrorDireccion";
            this.labelErrorDireccion.Size = new System.Drawing.Size(15, 20);
            this.labelErrorDireccion.TabIndex = 14;
            this.labelErrorDireccion.Text = "*";
            // 
            // labelErrorCiudad
            // 
            this.labelErrorCiudad.AutoSize = true;
            this.labelErrorCiudad.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCiudad.Location = new System.Drawing.Point(277, 135);
            this.labelErrorCiudad.Name = "labelErrorCiudad";
            this.labelErrorCiudad.Size = new System.Drawing.Size(15, 20);
            this.labelErrorCiudad.TabIndex = 15;
            this.labelErrorCiudad.Text = "*";
            // 
            // AltaBajasModifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(472, 225);
            this.Controls.Add(this.labelErrorCiudad);
            this.Controls.Add(this.labelErrorDireccion);
            this.Controls.Add(this.labelErrorNombre);
            this.Controls.Add(this.labelErrorId);
            this.Controls.Add(this.labelElimina);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelCiudad);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AltaBajasModifForm";
            this.Text = "AltaBajasModifForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelElimina;
        private System.Windows.Forms.Label labelErrorId;
        private System.Windows.Forms.Label labelErrorNombre;
        private System.Windows.Forms.Label labelErrorDireccion;
        private System.Windows.Forms.Label labelErrorCiudad;
    }
}