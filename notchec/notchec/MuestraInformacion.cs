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
    partial class MuestraInformacion : Form
    {
        string tipo;
        string titulo;
        List<string> lstProveedores;
        List<Cliente> lstClientes;
        int iD;

        public MuestraInformacion(string texto, List<string> provedores)
        {
            InitializeComponent();
            this.Text = "Proveedores -" + texto;
            tipo = "Proveedores";
            lstProveedores = provedores;
            titulo = texto;
            lstClientes = new List<Cliente>();
            iD = 0;
            muestraProveedor();
        }

        public MuestraInformacion(string texto, List<Cliente> clientes)
        {
            InitializeComponent();
            this.Text = "Clientes -" + texto;
            tipo = "Clientes";
            lstClientes = clientes;
            titulo = texto;
            lstProveedores = new List<string>();
            muestraClientes();
            iD = 0;
        }

        public int getId()
        {
            return iD;
        }

        private void muestraClientes()
        {
            listView1.Clear();
            //listView1.Columns.Add("iD", 70);
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Direccion", 150);
            listView1.Columns.Add("Ciudad", 150);
            for (short i = 0; i < lstClientes.Count; i++)
            {
               // listView1.Items.Add((i + 1).ToString());
                //listView1.Items[i].SubItems.Add(lstClientes[i].getNombre());
                listView1.Items.Add(lstClientes[i].getNombre());
                listView1.Items[i].SubItems.Add(lstClientes[i].getDireccion());
                listView1.Items[i].SubItems.Add(lstClientes[i].getCiudad());
            }
            
        }

        private void muestraProveedor()
        {
            listView1.Clear();
            //listView1.Columns.Add("iD", 50);
            listView1.Columns.Add("Nombre", 300);
            for (short i = 0; i < lstProveedores.Count; i++)
            {
                //listView1.Items.Add((i + 1).ToString());
                //listView1.Items[i].SubItems.Add(lstProveedores[i]);
                listView1.Items.Add((lstProveedores[i]));
            }
        }

        private void clickEditar(object sender, EventArgs e)
        {
            AltaBajasModifForm form;
            int opcion = 0;
            switch (sender.ToString())
            {
                case "Agregar":
                    opcion = 0;
                    break;
                case "Eliminar":
                    opcion = 1;
                    break;
                case "Modificar":
                    opcion = 2;
                    break;
            }
            if (tipo == "Clientes")
            {
                form = new AltaBajasModifForm(titulo, "Cliente", opcion, lstClientes);
                form.ShowDialog();
                lstClientes = form.getListCliente();
                lstClientes.Sort(
                delegate(Cliente a, Cliente b)
                {
                    return a.getNombre().CompareTo(b.getNombre());
                });
                muestraClientes();
            }
            else
            {
                form = new AltaBajasModifForm(titulo, "Proveedor", opcion, lstProveedores);
                form.ShowDialog();
                lstProveedores = form.getListProveedor();
                lstProveedores.Sort(delegate(string a, string b)
                {
                    return a.CompareTo(b);
                });
                muestraProveedor();
            }
           
        }

        private void Salir(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seleccionId(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            iD = e.ItemIndex;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
