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
    public partial class Notas : Form
    {
        List<Movimiento> lstMov;
        List<Cliente> clientes;
        string nombreArchivo;
        string titulo;
        MovimientoForm formMov;
        double total;

        public Notas(string tituloTexto)
        {
            InitializeComponent();
            titulo = tituloTexto;
            lstMov = new List<Movimiento>();
            this.Text = "Notas -" + tituloTexto;
            total = 0.00;
            muestraMovimientos();
            clientes = new List<Cliente>();
            nombreArchivo = @"c:\notchec2\clientes.notchec";
            creaArchivo();
            deserializaLista();

        }

        private void deserializaLista()
        {
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                clientes = (List<Cliente>)formater.Deserialize(stream);
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
                formater.Serialize(stream, clientes);
                stream.Close();
            }
        }

        private void serializa()
        {
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
            clientes.Sort(
                delegate(Cliente a ,Cliente b){
                    return a.getNombre().CompareTo(b.getNombre());
                });
            formater.Serialize(stream, clientes);
            stream.Close();
        }

        private void MenuArchivo(object sender, EventArgs e)
        {
            
            Nota n;
            switch (sender.ToString())
            {
                case "Nueva":
                case "Nuevo":
                    limpiarCampos();
                break;
                case "Imprimir...":
                case "Imprimir":
                    print p;
                    p = new print();
                    n = validaNota();
                    if (n != null)
                        p.imprimir(n);
                    else
                        MessageBox.Show("Existen campos Vacios o erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
                case "Salir...":
                case "Salir":
                    this.Close();
                break;
            }
        }

        private Nota validaNota()
        {
            Cliente nuevo;
            Nota n= new Nota();

            nuevo=validaCliente();
            if (nuevo != null)
            {
                n.setCliente(nuevo);
                n.setFecha(dateTimePicker1.Value);
                n.setFolio(textBoxNumNota.Text);
                n.setListaMov(lstMov);
                n.setTotalNumerico(total);
                n.setBandPrecio(checkBoxImporte.Checked);
                n.setBandLetra(checkBoxLetra.Checked);
                return n;
            }
            else
            {
                MessageBox.Show("Verifique que los datos del Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
                
        }

        private Cliente validaCliente()
        {
            Cliente nuevo = new Cliente();
            bool band, exitocl;

            exitocl = true;
            band=nuevo.setNombre(textBoxNombre.Text.Trim());
            if (!band)
                exitocl = false;
            band = nuevo.setDireccion(textBoxDireccion.Text.Trim());
            if (!band)
                exitocl = false;
            band = nuevo.setCiudad(textBoxCiudad.Text.Trim());
            if (!band)
                exitocl = false;
            if (exitocl)
                return nuevo;
            else
                return null;
        }

        private void MenuMovimientos(object sender, EventArgs e)
        {
            switch (sender.ToString())
            {
                case "Nuevo Movimiento":
                case "Nuevo":
                    formMov = new MovimientoForm(titulo,lstMov.Count+1);
                    if (formMov.ShowDialog() == DialogResult.OK)
                    {
                        lstMov.Add(formMov.getMovimiento());
                        muestraMovimientos();
                    }
                break;
                case "Modificar":
                case "Modifica Movimiento":
                    modificaMovimiento(1);
                break;
                case "Eliminar":
                case "Elimina Movimiento":
                    formMov = new MovimientoForm(titulo, lstMov,1,"Elimina");
                    if (formMov.ShowDialog() == DialogResult.OK)
                    {
                        lstMov.Remove(lstMov[formMov.getIdentificador()]);
                        muestraMovimientos();
                    }
                break;
            }
        }

        private void MenuAyuda(object sender, EventArgs e)
        {
            Ayuda ayuda;

            ayuda = new Ayuda(titulo);
            ayuda.ShowDialog();
        }

        private void muestraMovimientos()
        {
            Moneda mon;

            mon = new Moneda();
            listViewMovimientos.Items.Clear();
            total = 0.0;
            for (short i = 0; i < lstMov.Count; i++)
            {
                lstMov[i].setID((i+1).ToString());
                listViewMovimientos.Items.Add(lstMov[i].getId().ToString());
                listViewMovimientos.Items[i].SubItems.Add(lstMov[i].getCantidad().ToString());
                listViewMovimientos.Items[i].SubItems.Add(lstMov[i].getConcepto().ToString());
                listViewMovimientos.Items[i].SubItems.Add(valorMoneda(lstMov[i].getCosto()));
                listViewMovimientos.Items[i].SubItems.Add(valorMoneda(lstMov[i].getImporte()));
                total += lstMov[i].getImporte();
            }
            labelMuestraTotal.Text=valorMoneda(total);
            labelLetraTotal.Text = mon.Convertir(total.ToString(),false);
        }

        private string valorMoneda(double valor)
        {
            string ret;

            ret= String.Format("{0:C}", valor);
            return ret;
        }

        private void limpiarCampos()
        {
            textBoxCiudad.Clear();
            textBoxDireccion.Clear();
            textBoxNombre.Clear();
            textBoxNumNota.Clear();
            listViewMovimientos.Items.Clear();
            lstMov.Clear();
            total = 0.00;
            muestraMovimientos();
        }

        private void modificaMovimiento(int index)
        {
            Movimiento auxMov;
            int auxId;

            formMov = new MovimientoForm(titulo, lstMov, index, "Modifica");
            if (formMov.ShowDialog() == DialogResult.OK)
            {
                auxMov = formMov.getMovimiento();
                auxId = formMov.getIdentificador();
                lstMov[auxId].setConcepto(auxMov.getConcepto());
                lstMov[auxId].setCantidad(auxMov.getCantidad().ToString());
                lstMov[auxId].setCosto(auxMov.getCosto().ToString());
                lstMov[auxId].setImporte(auxMov.getImporte().ToString());
                muestraMovimientos();
            }
        }

        private void clickBuscar(object sender, EventArgs e)
        {
            MuestraInformacion mu;
            int iDaux;
            clientes.Sort(
                delegate(Cliente a, Cliente b)
                {
                    return a.getNombre().CompareTo(b.getNombre());
                });
            mu = new MuestraInformacion(titulo, clientes);
            if (mu.ShowDialog() == DialogResult.OK)
            {
                iDaux = mu.getId();
                textBoxCiudad.Text = clientes[iDaux].getCiudad();
                textBoxDireccion.Text = clientes[iDaux].getDireccion();
                textBoxNombre.Text = clientes[iDaux].getNombre(); 
            }
            serializa();
        }

        private void clickGuardar(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente();
            bool band=true;;
            bool bandExito=true;

            band=nuevo.setCiudad(textBoxCiudad.Text.Trim());
            if (!band)
                bandExito = false;
            band = nuevo.setDireccion(textBoxDireccion.Text.Trim());
            if (!band)
                bandExito = false;
            band = nuevo.setNombre(textBoxNombre.Text.Trim());
            if (!bandExito)
                MessageBox.Show("Verifique que los datos esten Correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                clientes.Add(nuevo);
                serializa();
                MessageBox.Show("Cliente guardado con exito", "Aviso!");
            }

        }
    }
}
