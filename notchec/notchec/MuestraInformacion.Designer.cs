namespace notchec
{
    partial class MuestraInformacion
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnToolAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnToolElimina = new System.Windows.Forms.ToolStripButton();
            this.btnToolModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnToolSalir = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(549, 521);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.seleccionId);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::notchec.Properties.Resources.exit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salirToolStripMenuItem.Text = "Salir...";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.Salir);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminar,
            this.btnModificar});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::notchec.Properties.Resources.add;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.clickEditar);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::notchec.Properties.Resources.remove;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.clickEditar);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::notchec.Properties.Resources.modificar;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(125, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.clickEditar);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnToolAgregar,
            this.btnToolElimina,
            this.btnToolModificar,
            this.toolStripSeparator1,
            this.btnToolSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(572, 39);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnToolAgregar
            // 
            this.btnToolAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolAgregar.Image = global::notchec.Properties.Resources.add;
            this.btnToolAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolAgregar.Name = "btnToolAgregar";
            this.btnToolAgregar.Size = new System.Drawing.Size(36, 36);
            this.btnToolAgregar.Text = "Agregar";
            this.btnToolAgregar.Click += new System.EventHandler(this.clickEditar);
            // 
            // btnToolElimina
            // 
            this.btnToolElimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolElimina.Image = global::notchec.Properties.Resources.remove;
            this.btnToolElimina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolElimina.Name = "btnToolElimina";
            this.btnToolElimina.Size = new System.Drawing.Size(36, 36);
            this.btnToolElimina.Text = "Eliminar";
            this.btnToolElimina.Click += new System.EventHandler(this.clickEditar);
            // 
            // btnToolModificar
            // 
            this.btnToolModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolModificar.Image = global::notchec.Properties.Resources.modificar;
            this.btnToolModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolModificar.Name = "btnToolModificar";
            this.btnToolModificar.Size = new System.Drawing.Size(36, 36);
            this.btnToolModificar.Text = "Modificar";
            this.btnToolModificar.Click += new System.EventHandler(this.clickEditar);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnToolSalir
            // 
            this.btnToolSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnToolSalir.Image = global::notchec.Properties.Resources.exit;
            this.btnToolSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnToolSalir.Name = "btnToolSalir";
            this.btnToolSalir.Size = new System.Drawing.Size(36, 36);
            this.btnToolSalir.Text = "Salir";
            this.btnToolSalir.Click += new System.EventHandler(this.Salir);
            // 
            // MuestraInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(572, 605);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MuestraInformacion";
            this.Text = "MuestraInformacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnToolAgregar;
        private System.Windows.Forms.ToolStripButton btnToolElimina;
        private System.Windows.Forms.ToolStripButton btnToolModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnToolSalir;
    }
}