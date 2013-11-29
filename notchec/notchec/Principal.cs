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
    public partial class Principal : Form
    {
        string titulo;
        public Principal(string nombrePrograma)
        {
            InitializeComponent();
            titulo = nombrePrograma;
            this.Text = "Menu - " + nombrePrograma;
        }

        private void clickOpcion(object sender, EventArgs e)
        {
            Ayuda ayuda;

            Button boton = (Button)sender;
            Notas notas;
            FormCheque cheques;
            Configuracion con;

            switch (boton.AccessibleName)
            {
                case "Notas":
                    this.Visible = false;
                    notas = new Notas(titulo);
                    notas.ShowDialog();
                    this.Visible = true;
                break;
                case "Cheques":
                    this.Visible = false;
                    cheques = new FormCheque(titulo);
                    cheques.ShowDialog();
                    this.Visible = true;
                break;
                case "Configuracion":
                    con = new Configuracion(titulo);
                    con.ShowDialog();
                break;
                case "Ayuda":
                    ayuda = new Ayuda(titulo);
                    ayuda.ShowDialog();
                break;
            }
        }
    }
}
