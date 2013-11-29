using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace notchec
{
    public partial class FormCheque : Form
    {

        Moneda moneda;
        List<string> proveedores;
        string nombreArchivo;
        string tit;

        public FormCheque(string titulo)
        {
            InitializeComponent();
            tit = titulo;
            this.Text = "Cheque- " + titulo;
            moneda = new Moneda();
            proveedores = new List<string>();
            labeltextoLetra.Text = "Error";
            nombreArchivo = @"c:\notchec2\proveedores.notchec";
            creaArchivo();
            deserializaLista();
        }

        private void menuArchivo(object sender, EventArgs e)
        {
            Ayuda ayuda;
            print imprimir = new print();
            Cheque ch;
            switch (sender.ToString())
            {
                case "Nuevo":
                    limpiaFormulario();
                    break;
                case "Salir...":
                case "Salir":
                    this.Close();
                    break;
                case "Acerca De...":
                case "Acerca De":
                    ayuda = new Ayuda(tit);
                    ayuda.ShowDialog();
                    break;
                case "Imprimir...":
                case "Imprimir":
                    ch = validaCheque();
                    if (ch == null)
                        MessageBox.Show("Existen campos Vacios o erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        imprimir.imprimir(ch);
               
                break;
            }
        }

        private Cheque validaCheque()
        {
            bool band,exito;
            Cheque ch = new Cheque();

            exito=true;
            if (!validaProveedor())
                exito = false;
            else
            {
                band = ch.setCantidad(textBoxCantidad.Text.Trim());
                if (!band)
                    exito = band;
                ch.setDate(dateTimePicker1.Value);
                ch.setEsPagare(checkBoxPoliza.Checked);
                band = ch.setFactura(textBoxFactura.Text.Trim());
                if (!band)
                    exito = band;
                ch.setLeyenda(checkBoxLeyenda.Checked);
                ch.setNombre(textBoxOrdenDe.Text.Trim());
                ch.setConcepto(textBoxConcepto.Text.Trim());
            }
            if (!exito)
                return null;
            return ch;
            
        }

        private void limpiaFormulario()
        {
            textBoxCantidad.Clear();
            textBoxFactura.Clear();
            textBoxOrdenDe.Clear();
            checkBoxLeyenda.Checked = false;
            textBoxConcepto.Clear();
            checkBoxPoliza.Checked = false;
        }

        private void deserializaLista()
        {
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                proveedores = (List<string>)formater.Deserialize(stream);
            }
            catch
            {
            }
            stream.Close();
        }

        private void creaArchivo()
        {
            IFormatter formater = new BinaryFormatter();
            if (!System.IO.File.Exists(nombreArchivo))
            {
                Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formater.Serialize(stream, proveedores);
                stream.Close();
            }
        }

        private void serializa()
        {
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
            proveedores.Sort(delegate(string a, string b)
            {
                return a.CompareTo(b);
            });
            formater.Serialize(stream, proveedores);
            stream.Close();
        }

        private void clickBuscar(object sender, EventArgs e)
        {
            MuestraInformacion mu;
            int valor;

            serializa();
            mu = new MuestraInformacion("Proveedor", proveedores);
            if (mu.ShowDialog() == DialogResult.OK)
            {
                valor = mu.getId();
                textBoxOrdenDe.Text = proveedores[valor];
            }
            serializa();
        }

        private void clickGuardar(object sender, EventArgs e)
        {
            if (validaProveedor())
            {
                proveedores.Add(textBoxOrdenDe.Text.Trim());
                MessageBox.Show("Provedor Guardado", "Aviso!");
            }
            else
                MessageBox.Show("Verifique que los datos esten Correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            serializa();
        }

        private bool validaProveedor()
        {
            string tex;

            tex = textBoxOrdenDe.Text.Trim();
            if (tex.Length <= 0)
                return false;
            return true;
        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
            double valor;

            try
            {
                valor = Convert.ToDouble(textBoxCantidad.Text);
                labeltextoLetra.Text = moneda.Convertir(valor.ToString(), false);
            }
            catch
            {
                labeltextoLetra.Text = "Error";
            }
            
        }
    }
}
