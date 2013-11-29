namespace notchec
{
    partial class FormCheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheque));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxConcepto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labeltextoLetra = new System.Windows.Forms.Label();
            this.checkBoxPoliza = new System.Windows.Forms.CheckBox();
            this.checkBoxLeyenda = new System.Windows.Forms.CheckBox();
            this.textBoxFactura = new System.Windows.Forms.TextBox();
            this.labelFactura = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxOrdenDe = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToolNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnToolImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnToolAcercaDe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.textBoxConcepto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.labeltextoLetra);
            this.groupBox1.Controls.Add(this.checkBoxPoliza);
            this.groupBox1.Controls.Add(this.checkBoxLeyenda);
            this.groupBox1.Controls.Add(this.textBoxFactura);
            this.groupBox1.Controls.Add(this.labelFactura);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.labelCantidad);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxOrdenDe);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxConcepto
            // 
            this.textBoxConcepto.Location = new System.Drawing.Point(127, 232);
            this.textBoxConcepto.Name = "textBoxConcepto";
            this.textBoxConcepto.Size = new System.Drawing.Size(448, 26);
            this.textBoxConcepto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Concepto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::notchec.Properties.Resources.find;
            this.btnBuscar.Location = new System.Drawing.Point(465, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 34);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.clickBuscar);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::notchec.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(425, 77);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.clickGuardar);
            // 
            // labeltextoLetra
            // 
            this.labeltextoLetra.AutoSize = true;
            this.labeltextoLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltextoLetra.Location = new System.Drawing.Point(40, 205);
            this.labeltextoLetra.Name = "labeltextoLetra";
            this.labeltextoLetra.Size = new System.Drawing.Size(45, 16);
            this.labeltextoLetra.TabIndex = 6;
            this.labeltextoLetra.Text = "label1";
            // 
            // checkBoxPoliza
            // 
            this.checkBoxPoliza.AutoSize = true;
            this.checkBoxPoliza.Location = new System.Drawing.Point(550, 170);
            this.checkBoxPoliza.Name = "checkBoxPoliza";
            this.checkBoxPoliza.Size = new System.Drawing.Size(70, 24);
            this.checkBoxPoliza.TabIndex = 5;
            this.checkBoxPoliza.Text = "Poliza";
            this.checkBoxPoliza.UseVisualStyleBackColor = true;
            // 
            // checkBoxLeyenda
            // 
            this.checkBoxLeyenda.AutoSize = true;
            this.checkBoxLeyenda.Location = new System.Drawing.Point(550, 136);
            this.checkBoxLeyenda.Name = "checkBoxLeyenda";
            this.checkBoxLeyenda.Size = new System.Drawing.Size(149, 24);
            this.checkBoxLeyenda.TabIndex = 4;
            this.checkBoxLeyenda.Text = "Imprimir Leyenda";
            this.checkBoxLeyenda.UseVisualStyleBackColor = true;
            // 
            // textBoxFactura
            // 
            this.textBoxFactura.Location = new System.Drawing.Point(165, 134);
            this.textBoxFactura.Name = "textBoxFactura";
            this.textBoxFactura.Size = new System.Drawing.Size(98, 26);
            this.textBoxFactura.TabIndex = 3;
            // 
            // labelFactura
            // 
            this.labelFactura.AutoSize = true;
            this.labelFactura.Location = new System.Drawing.Point(32, 134);
            this.labelFactura.Name = "labelFactura";
            this.labelFactura.Size = new System.Drawing.Size(106, 20);
            this.labelFactura.TabIndex = 5;
            this.labelFactura.Text = "Num Cheque:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(151, 36);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(162, 26);
            this.textBoxCantidad.TabIndex = 1;
            this.textBoxCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyUp);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(32, 34);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(77, 20);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(405, 34);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(294, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBoxOrdenDe
            // 
            this.textBoxOrdenDe.Location = new System.Drawing.Point(151, 81);
            this.textBoxOrdenDe.Name = "textBoxOrdenDe";
            this.textBoxOrdenDe.Size = new System.Drawing.Size(268, 26);
            this.textBoxOrdenDe.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(32, 84);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(113, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "A la Orden De:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuArchivo,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuArchivo
            // 
            this.btnMenuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnImprimir,
            this.toolStripSeparator1,
            this.btnSalir});
            this.btnMenuArchivo.Name = "btnMenuArchivo";
            this.btnMenuArchivo.Size = new System.Drawing.Size(60, 20);
            this.btnMenuArchivo.Text = "Archivo";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(129, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.menuArchivo);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(129, 22);
            this.btnImprimir.Text = "Imprimir...";
            this.btnImprimir.Click += new System.EventHandler(this.menuArchivo);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 22);
            this.btnSalir.Text = "Salir...";
            this.btnSalir.Click += new System.EventHandler(this.menuArchivo);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(136, 22);
            this.btnAcercaDe.Text = "Acerca De...";
            this.btnAcercaDe.Click += new System.EventHandler(this.menuArchivo);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolNuevo,
            this.btnToolImprimir,
            this.btnToolAcercaDe,
            this.toolStripSeparator2,
            this.btnToolSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnToolNuevo
            // 
            this.btnToolNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolNuevo.Image = global::notchec.Properties.Resources.cheques;
            this.btnToolNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolNuevo.Name = "btnToolNuevo";
            this.btnToolNuevo.Size = new System.Drawing.Size(36, 36);
            this.btnToolNuevo.Text = "Nuevo";
            this.btnToolNuevo.Click += new System.EventHandler(this.menuArchivo);
            // 
            // btnToolImprimir
            // 
            this.btnToolImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolImprimir.Image = global::notchec.Properties.Resources.print;
            this.btnToolImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolImprimir.Name = "btnToolImprimir";
            this.btnToolImprimir.Size = new System.Drawing.Size(36, 36);
            this.btnToolImprimir.Text = "Imprimir";
            this.btnToolImprimir.Click += new System.EventHandler(this.menuArchivo);
            // 
            // btnToolAcercaDe
            // 
            this.btnToolAcercaDe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolAcercaDe.Image = global::notchec.Properties.Resources.help;
            this.btnToolAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolAcercaDe.Name = "btnToolAcercaDe";
            this.btnToolAcercaDe.Size = new System.Drawing.Size(36, 36);
            this.btnToolAcercaDe.Text = "Acerca De";
            this.btnToolAcercaDe.Click += new System.EventHandler(this.menuArchivo);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // btnToolSalir
            // 
            this.btnToolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolSalir.Image = global::notchec.Properties.Resources.exit;
            this.btnToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolSalir.Name = "btnToolSalir";
            this.btnToolSalir.Size = new System.Drawing.Size(36, 36);
            this.btnToolSalir.Text = "Salir";
            this.btnToolSalir.Click += new System.EventHandler(this.menuArchivo);
            // 
            // FormCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(780, 394);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCheque";
            this.Text = "Cheque";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuArchivo;
        private System.Windows.Forms.ToolStripMenuItem btnNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnImprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAcercaDe;
        private System.Windows.Forms.ToolStripButton btnToolNuevo;
        private System.Windows.Forms.ToolStripButton btnToolImprimir;
        private System.Windows.Forms.ToolStripButton btnToolAcercaDe;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnToolSalir;
        private System.Windows.Forms.TextBox textBoxOrdenDe;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.CheckBox checkBoxPoliza;
        private System.Windows.Forms.CheckBox checkBoxLeyenda;
        private System.Windows.Forms.TextBox textBoxFactura;
        private System.Windows.Forms.Label labelFactura;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labeltextoLetra;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox textBoxConcepto;
        private System.Windows.Forms.Label label1;
    }
}