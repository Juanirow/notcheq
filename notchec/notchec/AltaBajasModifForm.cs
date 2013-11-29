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
    partial class AltaBajasModifForm : Form
    {

        List<Cliente> lstClientes;
        List<string> lstProvedores;
        int tipoMov;
        string tipoCaptura;
        bool exito;

        public AltaBajasModifForm(string text,string tipo,int caso,List<Cliente> clientes)
        {
            string casoTitulo="";

            InitializeComponent();
            lstClientes = clientes;
            lstProvedores = new List<string>();
            tipoCaptura = tipo;
            tipoMov = caso;
            exito = false;
            ocultaControles("Cliente");
            switch (caso)
            {
                case 0://alta
                    casoTitulo = "Alta";
                    habilitaBotones(1);
                    textBoxId.Text = getIdInicial(tipo).ToString();
                    break;
                case 1://baja
                    casoTitulo = "Eliminar";
                    habilitaBotones(2);
                    textBoxId.Text = clientes.Count.ToString();
                    break;
                case 2://modifica
                    casoTitulo = "Modificar";
                    habilitaBotones(2);
                    textBoxId.Text = clientes.Count.ToString();
                    break;
                    
            }
            this.Text=tipo+"("+casoTitulo+") -"+text;
        }

        public List<Cliente> getListCliente()
        {
            return lstClientes;
        }

        public List<string> getListProveedor()
        {
            return lstProvedores;
        }

        public AltaBajasModifForm(string text, string tipo, int caso, List<string> provedores)
        {
            InitializeComponent();
            this.Text = tipo + " -" + text;
            ocultaControles("Proveedor");
            lstClientes = new List<Cliente>();
            tipoCaptura = tipo;
            lstProvedores = provedores;
            tipoMov = caso;
            exito = false;
            if (caso != 0)
            {
                habilitaBotones(2);
                textBoxId.Text = provedores.Count.ToString();
            }
            else
            {
                habilitaBotones(caso);
                textBoxId.Text = getIdInicial(tipo).ToString();
            }
        }

        private int getCountList()
        {
            int valor = 0;
            switch (tipoCaptura)
            {
                case "Cliente":
                    valor = lstClientes.Count ;
                    break;
                case "Proveedor":
                    valor = lstProvedores.Count;
                    break;
            }
            return valor;
        }

        private int getIdInicial(string tipo)
        {
            int valor = -1;
            switch (tipo)
            {
                case "Cliente":
                    valor=lstClientes.Count + 1;
                break;
                case "Proveedor":
                    valor = lstProvedores.Count + 1;
                break;
            }
            return valor;
        }

        private void ocultaControles(string tipo)
        {
            labelErrorCiudad.Visible = false;
            labelErrorDireccion.Visible = false;
            labelErrorId.Visible = false;
            labelErrorNombre.Visible = false;
            switch (tipo)
            {
                case "Cliente":
                    textBoxNombre.Visible = true;
                    textBoxDireccion.Visible = true;
                    textBoxId.Visible = true;
                    textBoxCiudad.Visible = true;
                    labelElimina.Visible = false;
                    btnBuscar.Visible = true;
                    break;
                case "Proveedor":
                    textBoxNombre.Visible = true;
                    textBoxDireccion.Visible = false;
                    textBoxId.Visible = true;
                    textBoxCiudad.Visible = false;
                    labelElimina.Visible = false;
                    btnBuscar.Visible = true;
                    labelCiudad.Visible = false;
                    labelDireccion.Visible = false;
                    break;
            }
        }

        private void habilitaBotones(int caso)
        {
            labelErrorId.Visible = false;
            switch (caso)
            {
                case 1://alta
                    textBoxNombre.Enabled = true;
                    textBoxDireccion.Enabled = true;
                    textBoxId.Enabled = false;
                    textBoxCiudad.Enabled = true;
                    labelElimina.Visible = false;
                    btnBuscar.Visible = false;
                    break;
                case 2://baja,modifica
                    textBoxNombre.Enabled = false;
                    textBoxDireccion.Enabled = false;
                    textBoxId.Enabled = true;
                    textBoxCiudad.Enabled = false;
                    labelElimina.Visible = false;
                    btnBuscar.Visible = true;
                    break;
                case 3://baja2
                    labelElimina.Visible = true;
                    break;
                case 4://modifica
                    textBoxNombre.Enabled = true;
                    textBoxDireccion.Enabled = true;
                    textBoxId.Enabled = true;
                    textBoxCiudad.Enabled = true;
                    labelElimina.Visible = false;
                    btnBuscar.Visible = true;
                    break;
            }
        }

        private void buscaId(object sender, EventArgs e)
        {
            bool bandExito;
            int valor;

            exito = false;
            try
            {
                valor=Convert.ToInt32(textBoxId.Text.Trim());
                if (getCountList() >= valor && valor > 0)
                {
                    bandExito = true;
                    llenaControles(valor);
                }
                else
                    bandExito = false;
            }
            catch
            {
                bandExito=false;
            }
            if (!bandExito)
            {
                labelErrorId.Visible = true;
                vaciaControles();
                MessageBox.Show("Valor de Id fuera del rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                exito = false;
            }
            else
            {
                labelErrorId.Visible = false;
                if (tipoMov == 1)
                    habilitaBotones(3);
                else
                    habilitaBotones(4);
                exito = true;
            }
        }

        private void vaciaControles()
        {
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            textBoxCiudad.Clear();
            textBoxId.Clear();
        }

        private void llenaControles(int iD)
        {
            int identificador=iD-1;
            switch (tipoCaptura)
            {
                case "Cliente":
                    textBoxNombre.Text = lstClientes[identificador].getNombre();
                    textBoxDireccion.Text = lstClientes[identificador].getDireccion();
                    textBoxCiudad.Text = lstClientes[identificador].getCiudad();
                    break;
                case "Proveedor":
                    textBoxNombre.Text = lstProvedores[identificador];
                    break;
            }
        }

        private void clickAceptar(object sender, EventArgs e)
        {
            Cliente nuevo;
            int auxID;
            string proveNuevo;

            switch (tipoCaptura)
            {
                case "Cliente":
                    switch (tipoMov)
                    {
                        case 0:
                            nuevo=validaAltacliente();
                            if (nuevo != null)
                                lstClientes.Add(nuevo);
                            break;
                        case 2:
                            if (!validaModificacionCliente())
                                DialogResult = DialogResult.None;
                            break;
                        case 1:
                            auxID = validaEliminacionCliente();
                            if (auxID == -1)
                                DialogResult = DialogResult.None;
                            else
                                lstClientes.RemoveAt(auxID);
                            break;
                    }
                    break;
                case "Proveedor":
                    switch (tipoMov)
                    {
                        case 0:
                            proveNuevo = validaAltaProveedor();
                            if (proveNuevo != null)
                                lstProvedores.Add(proveNuevo);
                            break;
                        case 2:
                            if (!validaModificacionProveedor())
                                DialogResult = DialogResult.None;
                            break;
                        case 1:
                            auxID = validaEliminacionProveedor();
                            if (auxID == -1)
                                DialogResult = DialogResult.None;
                            else
                                lstProvedores.RemoveAt(auxID);
                            break;
                    }
                    break;
            }
        }

        private string validaAltaProveedor()
        {

            if (textBoxNombre.Text.Trim().Length > 0)
                return textBoxNombre.Text.Trim();
            else
                return null;
        }

        private Cliente validaAltacliente()
        {
            Cliente nuevo=new Cliente();
            bool band = true;
            bool bandExito = true;

            band = nuevo.setNombre(textBoxNombre.Text);
            if (!band)
            {
                bandExito = false;
                labelErrorNombre.Visible = true;
            }
            else
                labelErrorNombre.Visible = false;
            band = nuevo.setDireccion(textBoxDireccion.Text);
            if (!band)
            {
                bandExito = false;
                labelErrorDireccion.Visible = true;
            }
            else
                labelErrorDireccion.Visible = false;
            band = nuevo.setCiudad(textBoxCiudad.Text);
            if (!band)
            {
                bandExito = false;
                labelErrorCiudad.Visible = true;
            }
            else
                labelErrorCiudad.Visible = false;
            if (!bandExito)
            {
                MessageBox.Show("Verifique que los datos esten Correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
                nuevo = null;
            }
            return nuevo;
        }

        private int validaEliminacionCliente()
        {
            int ret;

            ret = Convert.ToInt32(textBoxId.Text) - 1;
            if (ret < lstClientes.Count)
                return ret;
            else
            {
                labelErrorId.Visible = true;
                vaciaControles();
                MessageBox.Show("Valor de Id fuera del rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            
        }

        private bool validaModificacionCliente()
        {
            int valor;
            Cliente nuevo;

            valor = validaEliminacionCliente();
            if (valor != -1)
            {
                nuevo = validaAltacliente();
                if (nuevo != null)
                {
                    lstClientes[valor] = nuevo;
                    return true;
                }
            }
            return false;
        }

        private int validaEliminacionProveedor()
        {
            int ret;

            ret = Convert.ToInt32(textBoxId.Text) - 1;
            if (ret < lstProvedores.Count)
                return ret;
            else
            {
                labelErrorId.Visible = true;
                vaciaControles();
                MessageBox.Show("Valor de Id fuera del rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private bool validaModificacionProveedor()
        {
            int valor;
            string nuevo;

            valor = validaEliminacionProveedor();
            if (valor != -1)
            {
                nuevo = validaAltaProveedor();
                if (nuevo != null)
                {
                    lstProvedores[valor] = nuevo;
                    return true;
                }
            }
            return false;
        }
    }
}
