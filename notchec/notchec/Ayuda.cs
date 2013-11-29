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
    public partial class Ayuda : Form
    {
        public Ayuda(string titulo)
        {
            InitializeComponent();
            this.Text = "Ayuda -" + titulo;

            labelTitulo.Text = "NotChec Version Beta 0.1";
            labelTexto.Text = "Este proyecto es idea y elaboracion de Juan Manuel Hernadez Liñan\n";
            labelTexto.Text += " todos los derechos reservados.\nPara dudas y aclaraciones comunicarse";
            labelTexto.Text += " a los telefonos \ncorrespondientes.";
        }
    }
}
