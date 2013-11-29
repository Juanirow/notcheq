using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notchec
{
    public partial class Form1 : Form
    {
        public const string NombreForm="NoteChec-Beta 0.3.1";
        Font f;
        Principal principal;

        public Form1()
        {
            InitializeComponent();
            this.Text = NombreForm;
            labelTextoBeta.Text = "Usted esta apunto de usar la version "+NombreForm+  "\n";
            labelTextoBeta.Text += "      pulse la imagen para continuar ";
            principal = new Principal(NombreForm);
            crearDirectorio();
        }

        private void clickImagen(object sender, EventArgs e)
        {
            this.Visible = false;
            principal.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void crearDirectorio()
        {
            string rutaDir;

            rutaDir = @"c:\notchec2";
            try
            {
                if(!System.IO.Directory.Exists(rutaDir))
                    System.IO.Directory.CreateDirectory(rutaDir);
            }
            catch
            {

            }
        }

    }
}
