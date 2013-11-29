namespace notchec
{
    partial class Notas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notas));
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNumNota = new System.Windows.Forms.TextBox();
            this.labelNumNota = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.labelCiudad = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.listViewMovimientos = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnConcepto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnImporte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnToolArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolNueva = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolImprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btnToolAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripImprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripNuevoMov = new System.Windows.Forms.ToolStripButton();
            this.toolStripmModifMov = new System.Windows.Forms.ToolStripButton();
            this.toolStripEliminaMov = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAcercaDe = new System.Windows.Forms.ToolStripButton();
            this.toolStripSalir = new System.Windows.Forms.ToolStripButton();
            this.labelLetraTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelMuestraTotal = new System.Windows.Forms.Label();
            this.checkBoxImporte = new System.Windows.Forms.CheckBox();
            this.checkBoxLetra = new System.Windows.Forms.CheckBox();
            this.groupBoxCliente.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.btnGuardar);
            this.groupBoxCliente.Controls.Add(this.btnBusca);
            this.groupBoxCliente.Controls.Add(this.dateTimePicker1);
            this.groupBoxCliente.Controls.Add(this.textBoxNumNota);
            this.groupBoxCliente.Controls.Add(this.labelNumNota);
            this.groupBoxCliente.Controls.Add(this.textBoxCiudad);
            this.groupBoxCliente.Controls.Add(this.labelCiudad);
            this.groupBoxCliente.Controls.Add(this.textBoxDireccion);
            this.groupBoxCliente.Controls.Add(this.labelDireccion);
            this.groupBoxCliente.Controls.Add(this.textBoxNombre);
            this.groupBoxCliente.Controls.Add(this.labelNombre);
            this.groupBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCliente.Location = new System.Drawing.Point(45, 66);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(657, 147);
            this.groupBoxCliente.TabIndex = 0;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "Guardar";
            this.btnGuardar.Image = global::notchec.Properties.Resources.save;
            this.btnGuardar.Location = new System.Drawing.Point(414, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 33);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.clickGuardar);
            // 
            // btnBusca
            // 
            this.btnBusca.AccessibleName = "Buscar";
            this.btnBusca.Image = global::notchec.Properties.Resources.find;
            this.btnBusca.Location = new System.Drawing.Point(453, 26);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(40, 36);
            this.btnBusca.TabIndex = 10;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.clickBuscar);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(342, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // textBoxNumNota
            // 
            this.textBoxNumNota.Location = new System.Drawing.Point(310, 108);
            this.textBoxNumNota.MaxLength = 25;
            this.textBoxNumNota.Name = "textBoxNumNota";
            this.textBoxNumNota.Size = new System.Drawing.Size(121, 26);
            this.textBoxNumNota.TabIndex = 4;
            // 
            // labelNumNota
            // 
            this.labelNumNota.AutoSize = true;
            this.labelNumNota.Location = new System.Drawing.Point(244, 109);
            this.labelNumNota.Name = "labelNumNota";
            this.labelNumNota.Size = new System.Drawing.Size(60, 20);
            this.labelNumNota.TabIndex = 6;
            this.labelNumNota.Text = "# Nota:";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(103, 108);
            this.textBoxCiudad.MaxLength = 25;
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(121, 26);
            this.textBoxCiudad.TabIndex = 3;
            // 
            // labelCiudad
            // 
            this.labelCiudad.AutoSize = true;
            this.labelCiudad.Location = new System.Drawing.Point(18, 109);
            this.labelCiudad.Name = "labelCiudad";
            this.labelCiudad.Size = new System.Drawing.Size(63, 20);
            this.labelCiudad.TabIndex = 4;
            this.labelCiudad.Text = "Ciudad:";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(103, 70);
            this.textBoxDireccion.MaxLength = 100;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(233, 26);
            this.textBoxDireccion.TabIndex = 2;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(18, 71);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(79, 20);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Direccion:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(103, 31);
            this.textBoxNombre.MaxLength = 100;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(285, 26);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(18, 32);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(69, 20);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre:";
            // 
            // listViewMovimientos
            // 
            this.listViewMovimientos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnCantidad,
            this.columnConcepto,
            this.columnImporte,
            this.columnTotal});
            this.listViewMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMovimientos.Location = new System.Drawing.Point(45, 233);
            this.listViewMovimientos.Name = "listViewMovimientos";
            this.listViewMovimientos.Size = new System.Drawing.Size(651, 301);
            this.listViewMovimientos.TabIndex = 1;
            this.listViewMovimientos.UseCompatibleStateImageBehavior = false;
            this.listViewMovimientos.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "iD";
            this.columnId.Width = 39;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            this.columnCantidad.Width = 79;
            // 
            // columnConcepto
            // 
            this.columnConcepto.Text = "Concepto";
            this.columnConcepto.Width = 250;
            // 
            // columnImporte
            // 
            this.columnImporte.Text = "Importe";
            this.columnImporte.Width = 112;
            // 
            // columnTotal
            // 
            this.columnTotal.Text = "Total";
            this.columnTotal.Width = 87;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolArchivo,
            this.btnToolMovimientos,
            this.btnAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnToolArchivo
            // 
            this.btnToolArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolNueva,
            this.btnToolImprimir,
            this.toolStripSeparator1,
            this.btnToolSalir});
            this.btnToolArchivo.Name = "btnToolArchivo";
            this.btnToolArchivo.Size = new System.Drawing.Size(60, 20);
            this.btnToolArchivo.Text = "Archivo";
            // 
            // btnToolNueva
            // 
            this.btnToolNueva.Image = global::notchec.Properties.Resources.nuevo;
            this.btnToolNueva.Name = "btnToolNueva";
            this.btnToolNueva.Size = new System.Drawing.Size(129, 22);
            this.btnToolNueva.Text = "Nueva";
            this.btnToolNueva.Click += new System.EventHandler(this.MenuArchivo);
            // 
            // btnToolImprimir
            // 
            this.btnToolImprimir.Image = global::notchec.Properties.Resources.print;
            this.btnToolImprimir.Name = "btnToolImprimir";
            this.btnToolImprimir.Size = new System.Drawing.Size(129, 22);
            this.btnToolImprimir.Text = "Imprimir...";
            this.btnToolImprimir.Click += new System.EventHandler(this.MenuArchivo);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // btnToolSalir
            // 
            this.btnToolSalir.Image = global::notchec.Properties.Resources.exit;
            this.btnToolSalir.Name = "btnToolSalir";
            this.btnToolSalir.Size = new System.Drawing.Size(129, 22);
            this.btnToolSalir.Text = "Salir...";
            this.btnToolSalir.Click += new System.EventHandler(this.MenuArchivo);
            // 
            // btnToolMovimientos
            // 
            this.btnToolMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolNuevo,
            this.btnToolModificar,
            this.btnToolEliminar,
            this.toolStripSeparator4,
            this.btnBuscarCliente,
            this.btnGuardarCliente});
            this.btnToolMovimientos.Name = "btnToolMovimientos";
            this.btnToolMovimientos.Size = new System.Drawing.Size(89, 20);
            this.btnToolMovimientos.Text = "Movimientos";
            // 
            // btnToolNuevo
            // 
            this.btnToolNuevo.Image = global::notchec.Properties.Resources.nuevo2;
            this.btnToolNuevo.Name = "btnToolNuevo";
            this.btnToolNuevo.Size = new System.Drawing.Size(156, 22);
            this.btnToolNuevo.Text = "Nuevo";
            this.btnToolNuevo.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // btnToolModificar
            // 
            this.btnToolModificar.Image = global::notchec.Properties.Resources.edit;
            this.btnToolModificar.Name = "btnToolModificar";
            this.btnToolModificar.Size = new System.Drawing.Size(156, 22);
            this.btnToolModificar.Text = "Modificar";
            this.btnToolModificar.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // btnToolEliminar
            // 
            this.btnToolEliminar.Image = global::notchec.Properties.Resources.eliminar;
            this.btnToolEliminar.Name = "btnToolEliminar";
            this.btnToolEliminar.Size = new System.Drawing.Size(156, 22);
            this.btnToolEliminar.Text = "Eliminar";
            this.btnToolEliminar.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::notchec.Properties.Resources.find;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(156, 22);
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(156, 22);
            this.btnGuardarCliente.Text = "Guardar Cliente";
            this.btnGuardarCliente.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // btnAyuda
            // 
            this.btnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolAcercaDe});
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(53, 20);
            this.btnAyuda.Text = "Ayuda";
            // 
            // btnToolAcercaDe
            // 
            this.btnToolAcercaDe.Image = global::notchec.Properties.Resources.acercaDe;
            this.btnToolAcercaDe.Name = "btnToolAcercaDe";
            this.btnToolAcercaDe.Size = new System.Drawing.Size(135, 22);
            this.btnToolAcercaDe.Text = "Acerca de...";
            this.btnToolAcercaDe.Click += new System.EventHandler(this.MenuAyuda);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNuevo,
            this.toolStripImprimir,
            this.toolStripSeparator2,
            this.toolStripNuevoMov,
            this.toolStripmModifMov,
            this.toolStripEliminaMov,
            this.toolStripSeparator3,
            this.toolStripAcercaDe,
            this.toolStripSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(742, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNuevo
            // 
            this.toolStripNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNuevo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNuevo.Image")));
            this.toolStripNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNuevo.Name = "toolStripNuevo";
            this.toolStripNuevo.Size = new System.Drawing.Size(36, 36);
            this.toolStripNuevo.Text = "Nuevo";
            this.toolStripNuevo.Click += new System.EventHandler(this.MenuArchivo);
            // 
            // toolStripImprimir
            // 
            this.toolStripImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripImprimir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripImprimir.Image")));
            this.toolStripImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripImprimir.Name = "toolStripImprimir";
            this.toolStripImprimir.Size = new System.Drawing.Size(36, 36);
            this.toolStripImprimir.Text = "Imprimir";
            this.toolStripImprimir.Click += new System.EventHandler(this.MenuArchivo);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripNuevoMov
            // 
            this.toolStripNuevoMov.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNuevoMov.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNuevoMov.Image")));
            this.toolStripNuevoMov.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNuevoMov.Name = "toolStripNuevoMov";
            this.toolStripNuevoMov.Size = new System.Drawing.Size(36, 36);
            this.toolStripNuevoMov.Text = "Nuevo Movimiento";
            this.toolStripNuevoMov.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // toolStripmModifMov
            // 
            this.toolStripmModifMov.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripmModifMov.Image = ((System.Drawing.Image)(resources.GetObject("toolStripmModifMov.Image")));
            this.toolStripmModifMov.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripmModifMov.Name = "toolStripmModifMov";
            this.toolStripmModifMov.Size = new System.Drawing.Size(36, 36);
            this.toolStripmModifMov.Text = "Modifica Movimiento";
            this.toolStripmModifMov.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // toolStripEliminaMov
            // 
            this.toolStripEliminaMov.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripEliminaMov.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEliminaMov.Image")));
            this.toolStripEliminaMov.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEliminaMov.Name = "toolStripEliminaMov";
            this.toolStripEliminaMov.Size = new System.Drawing.Size(36, 36);
            this.toolStripEliminaMov.Text = "Elimina Movimiento";
            this.toolStripEliminaMov.Click += new System.EventHandler(this.MenuMovimientos);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripAcercaDe
            // 
            this.toolStripAcercaDe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripAcercaDe.Image")));
            this.toolStripAcercaDe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAcercaDe.Name = "toolStripAcercaDe";
            this.toolStripAcercaDe.Size = new System.Drawing.Size(36, 36);
            this.toolStripAcercaDe.Text = "Acerca De ";
            this.toolStripAcercaDe.Click += new System.EventHandler(this.MenuAyuda);
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSalir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSalir.Image")));
            this.toolStripSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(36, 36);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.MenuArchivo);
            // 
            // labelLetraTotal
            // 
            this.labelLetraTotal.AutoSize = true;
            this.labelLetraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetraTotal.Location = new System.Drawing.Point(43, 631);
            this.labelLetraTotal.Name = "labelLetraTotal";
            this.labelLetraTotal.Size = new System.Drawing.Size(0, 16);
            this.labelLetraTotal.TabIndex = 6;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(455, 628);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(48, 20);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Total:";
            // 
            // labelMuestraTotal
            // 
            this.labelMuestraTotal.AutoSize = true;
            this.labelMuestraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMuestraTotal.Location = new System.Drawing.Point(509, 628);
            this.labelMuestraTotal.Name = "labelMuestraTotal";
            this.labelMuestraTotal.Size = new System.Drawing.Size(0, 20);
            this.labelMuestraTotal.TabIndex = 8;
            // 
            // checkBoxImporte
            // 
            this.checkBoxImporte.AutoSize = true;
            this.checkBoxImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxImporte.Location = new System.Drawing.Point(459, 557);
            this.checkBoxImporte.Name = "checkBoxImporte";
            this.checkBoxImporte.Size = new System.Drawing.Size(143, 24);
            this.checkBoxImporte.TabIndex = 12;
            this.checkBoxImporte.Text = "Imprimir Importe";
            this.checkBoxImporte.UseVisualStyleBackColor = true;
            // 
            // checkBoxLetra
            // 
            this.checkBoxLetra.AutoSize = true;
            this.checkBoxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLetra.Location = new System.Drawing.Point(459, 587);
            this.checkBoxLetra.Name = "checkBoxLetra";
            this.checkBoxLetra.Size = new System.Drawing.Size(194, 24);
            this.checkBoxLetra.TabIndex = 13;
            this.checkBoxLetra.Text = "Imprimir Total con Letra";
            this.checkBoxLetra.UseVisualStyleBackColor = true;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(742, 674);
            this.Controls.Add(this.checkBoxLetra);
            this.Controls.Add(this.checkBoxImporte);
            this.Controls.Add(this.labelMuestraTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelLetraTotal);
            this.Controls.Add(this.listViewMovimientos);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Notas";
            this.Text = "Notas";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.ListView listViewMovimientos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnToolArchivo;
        private System.Windows.Forms.ToolStripMenuItem btnToolNueva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnToolSalir;
        private System.Windows.Forms.ToolStripMenuItem btnToolMovimientos;
        private System.Windows.Forms.ToolStripMenuItem btnToolNuevo;
        private System.Windows.Forms.ToolStripMenuItem btnToolEliminar;
        private System.Windows.Forms.ToolStripMenuItem btnToolModificar;
        private System.Windows.Forms.ToolStripMenuItem btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem btnToolAcercaDe;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNumNota;
        private System.Windows.Forms.Label labelNumNota;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ToolStripMenuItem btnToolImprimir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private System.Windows.Forms.ColumnHeader columnConcepto;
        private System.Windows.Forms.ColumnHeader columnImporte;
        private System.Windows.Forms.ColumnHeader columnTotal;
        private System.Windows.Forms.ToolStripButton toolStripNuevo;
        private System.Windows.Forms.ToolStripButton toolStripImprimir;
        private System.Windows.Forms.ToolStripButton toolStripSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripNuevoMov;
        private System.Windows.Forms.ToolStripButton toolStripmModifMov;
        private System.Windows.Forms.ToolStripButton toolStripEliminaMov;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripAcercaDe;
        private System.Windows.Forms.Label labelLetraTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMuestraTotal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnBuscarCliente;
        private System.Windows.Forms.ToolStripMenuItem btnGuardarCliente;
        private System.Windows.Forms.CheckBox checkBoxImporte;
        private System.Windows.Forms.CheckBox checkBoxLetra;
    }
}