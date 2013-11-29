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
    partial class MovimientoForm : Form
    {
        Movimiento mov;
        bool exito;
        List<Movimiento> lstMov;
        string tipoMovimiento;
        int iD;

        public MovimientoForm(string titulo,int identificador)
        {
            InitializeComponent();
            this.Text = "Movimiento-Alta-" + titulo;
            mov = new Movimiento();
            habilitaBotones(0);
            exito = false;
            lstMov = new List<Movimiento>();
            iD = identificador;
            textBoxId.Text = iD.ToString();
            tipoMovimiento = "Alta";
        }

        public MovimientoForm(string titulo, List<Movimiento> listMov,int Id,string tipo)
        {
            InitializeComponent();
            this.Text = "Movimiento-"+tipo +"- "+ titulo;
            lstMov = listMov;
            mov = new Movimiento();
            if(tipo=="Elimina")
                habilitaBotones(3);
            else
                habilitaBotones(1);
            exito = false;
            tipoMovimiento = tipo;
            textBoxId.Text = Id.ToString();
        }

        public int getIdentificador()
        {
            return iD;
        }

        public Movimiento getMovimiento()
        {
            return mov;
        }

        public void habilitaBotones(int tipo)
        {
            labelErrorCantidad.Visible = false;
            labelerrorConcepto.Visible = false;
            labelErrorCosto.Visible = false;
            labelerrorId.Visible = false;
            switch (tipo)
            {
                case 0://nueva
                    btnImagen.Text = "Nuevo";
                    textBoxId.ReadOnly = true;
                    textBoxCantidad.ReadOnly = false;
                    textBoxConcepto.ReadOnly = false;
                    textBoxCosto.ReadOnly = false;
                    textBoxImporte.ReadOnly = true;
                    btnBuscar.Visible=false;
                    labelMensajeElimina.Visible = false;
                break;
                case 1://modifica antes de buscar 
                    btnImagen.Text = "Modificar";    
                    textBoxId.ReadOnly = false;
                    textBoxCantidad.ReadOnly = true;
                    textBoxConcepto.ReadOnly = true;
                    textBoxCosto.ReadOnly = true;
                    textBoxImporte.ReadOnly = true;
                    btnBuscar.Visible = true;
                    labelMensajeElimina.Visible = false;
                break;
                case 2://modifica despues de buscar
                    textBoxCantidad.ReadOnly = false;
                    textBoxConcepto.ReadOnly = false;
                    textBoxCosto.ReadOnly = false;
                    btnBuscar.Visible=false;
                    labelMensajeElimina.Visible = false;
                break;
                case 3://eliminar antes de buscar
                    btnImagen.Text = "Elimina";
                    textBoxId.ReadOnly = false;
                    textBoxCantidad.ReadOnly = true;
                    textBoxConcepto.ReadOnly = true;
                    textBoxCosto.ReadOnly = true;
                    textBoxImporte.ReadOnly = true;
                    btnBuscar.Visible = true;
                    labelMensajeElimina.Visible = false;
                break;
                case 4:// elimina despues de buscar
                     textBoxCantidad.ReadOnly = true;
                     textBoxConcepto.ReadOnly = true;
                     textBoxCosto.ReadOnly = true;
                     btnBuscar.Visible = true;
                    labelMensajeElimina.Visible = true;
                break;
            }
        }

        public void validaEnAlta()
        {
            bool band;
            double valor;

            exito = true;
            band = mov.setCantidad(textBoxCantidad.Text);
            if (!band)
            {
                exito = false;
                labelErrorCantidad.Visible = true;
            }
            else
                labelErrorCantidad.Visible = false;
            band = mov.setConcepto(textBoxConcepto.Text);
            if (!band)
            {
                exito = false;
                labelerrorConcepto.Visible = true;
            }
            else
                labelerrorConcepto.Visible = false;
            band = mov.setCosto(textBoxCosto.Text);
            if (!band)
            {
                exito = false;
                labelErrorCosto.Visible = true;
            }
            else
                labelErrorCosto.Visible = false;
            band = mov.setID(textBoxId.Text);
            if (!band)
            {
                exito = false;
                labelerrorId.Visible = true;
            }
            else
                labelerrorId.Visible = false;
            if (!exito)
            {
                MessageBox.Show("Verifique que los datos esten Correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            else
            {
                valor = mov.getCantidad() * mov.getCosto();
                mov.setImporte(valor.ToString());
            }
            if (!exito)
                DialogResult = DialogResult.None;   
        }

        private void clickOk(object sender, EventArgs e)
        {
            if (tipoMovimiento == "Alta")
                validaEnAlta();
            if (tipoMovimiento == "Elimina")
                if (!exito)
                    DialogResult = DialogResult.Cancel;
            if (tipoMovimiento == "Modifica")
                validaEnAlta();
        }

        private void clickBuscar(object sender, EventArgs e)
        {
            int valor;
            try
            {
                valor = Convert.ToInt32(textBoxId.Text.Trim());
                if (valor <= lstMov.Count && valor > 0)
                {
                    exito = true;
                    iD = valor - 1;
                    textBoxCantidad.Text = lstMov[iD].getCantidad().ToString();
                    textBoxConcepto.Text = lstMov[iD].getConcepto();
                    textBoxCosto.Text = lstMov[iD].getCosto().ToString();
                    textBoxImporte.Text = lstMov[iD].getImporte().ToString();
                    labelerrorId.Visible = false;
                    if (tipoMovimiento == "Elimina")
                        habilitaBotones(4);
                    else
                        habilitaBotones(2);
                }
                else
                {
                    exito = false;
                    textBoxCantidad.Clear();
                    textBoxConcepto.Clear();
                    textBoxCosto.Clear();
                    textBoxImporte.Clear();
                    labelerrorId.Visible = true;
                    MessageBox.Show("Valor de Id fuera del rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                exito = false;
                MessageBox.Show("Verifique que los datos esten Correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CambioTexto(object sender, EventArgs e)
        {
            double cantidad,precio,total;

            try
            {
                cantidad = Convert.ToDouble(textBoxCantidad.Text.Trim());
                precio = Convert.ToDouble(textBoxCosto.Text.Trim());
                total = cantidad * precio;
                textBoxImporte.Text = valorMoneda(total);
            }
            catch
            {
                textBoxImporte.Text = valorMoneda(0.0);
            }
        }
        private string valorMoneda(double valor)
        {
            string ret;

            ret = String.Format("{0:C}", valor);
            return ret;
        }
    }
}
