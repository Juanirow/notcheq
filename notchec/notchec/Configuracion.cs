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
    partial class Configuracion : Form
    {

        List<FormatoNota> configuraciones;
        List<FormatoCheque> lstC;
        string nombreArchivo,titulo,nombreCheque;
        int tipo;
        bool bandNuevo;

        public Configuracion(string title)
        {
            InitializeComponent();
            titulo = title;
            this.Text = "Configuracion -" + title;
            configuraciones = new List<FormatoNota>();
            lstC = new List<FormatoCheque>();
            nombreArchivo = @"c:\notchec2\conf.notchec";
            nombreCheque = @"c:\notchec2\confch.notchec";
            creaArchivos();
            deserializaListas();
            actualizaGrupos("Notas");
            tipo = 1;
        }


        //notas

        public FormatoNota getFormatoNotaActual()
        {
            foreach (FormatoNota n in configuraciones)
            {
                if (n.getActivo())
                    return n;
            }
            return null;
        }

        private void preparaNotas()
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            errorNombreConf.Visible = false;
            labelNombreNuevo.Visible = false;
            textBoxNombreNuevo.Visible = false;
            quitaErrores();
            btnGuardar.Enabled = false;
        }

        private void quitaErrores()
        {
            errorCantidadNota.Visible = false;
            ErrorCiudad.Visible = false;
            errorConcepto.Visible = false;
            ErrorDireccion.Visible = false;
            errorFecha.Visible = false;
            errorFolio.Visible = false;
            errorImporte.Visible = false;
            errorInicio.Visible = false;
            errorNombre.Visible = false;
            errorPrecio.Visible = false;
            errorTamFuente.Visible = false;
            errorTotalLetraNota.Visible = false;
            errorTotalNumeroNota.Visible = false;
            errorYGeneral.Visible = false;
            errorInterlineado.Visible = false;
        }

        private void llenaComboBoxNotas()
        {
            bool activo = false;

            comboBoxConfAct.Items.Clear();
            if (configuraciones.Count != 0)
            {
                for (short i = 0; i < configuraciones.Count; i++)
                {
                    comboBoxConfAct.Items.Add(configuraciones[i].getNombreConf());
                    if (configuraciones[i].getActivo())
                    {
                        comboBoxConfAct.SelectedIndex = i;
                        activo = true;
                    }

                }
            }
            if (!activo)
            {
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;
            }
        }

        private void reestableceValoresNotas()
        {
            comboBoxFuente.SelectedIndex = 0;
            textBoxInicio.Clear();
            //comboBoxConfAct.SelectedItem = configuraciones[index].getTipoFuente();
            textBoxTamFuente.Clear();
            labelEjemplo.Font = new Font(comboBoxFuente.SelectedItem.ToString(), 9);
            textBoxFechaX.Clear();
            textBoxFechaY.Clear();
            textBoxFolioX.Clear();
            textBoxFolioY.Clear();
            //cliente
            textBoxNombreX.Clear();
            textBoxNombreY.Clear();
            textBoxDireccionX.Clear();
            textBoxDireccionY.Clear();
            textBoxCiudadX.Clear();
            textBoxCiudadY.Clear();
            //movimientos
            textBoxYGeneral.Clear();
            textBoxCantidadX.Clear();
            textBoxConceptoX.Clear();
            textBoxPrecioX.Clear();
            textBoxImporteX.Clear();
            //totales
            textBoxTotalLetraX.Clear();
            textBoxTotalLetraY.Clear();
            textBoxTotalNumeroX.Clear();
            textBoxTotalNumeroY.Clear();
            textBoxIntelineado.Clear();
        }

        private void cargaValoresNotas(int index)
        {
            //General
            textBoxInicio.Text = configuraciones[index].getInicio().ToString();
            comboBoxFuente.SelectedItem = configuraciones[index].getTipoFuente();
            textBoxTamFuente.Text = configuraciones[index].getTamFuente().ToString();
            labelEjemplo.Font = new Font(configuraciones[index].getTipoFuente(), 9);
            textBoxFechaX.Text = configuraciones[index].getFecha().getX().ToString();
            textBoxFechaY.Text = configuraciones[index].getFecha().getY().ToString();
            textBoxFolioX.Text = configuraciones[index].getFolio().getX().ToString();
            textBoxFolioY.Text = configuraciones[index].getFolio().getY().ToString();
            //cliente
            textBoxNombreX.Text = configuraciones[index].getNombre().getX().ToString();
            textBoxNombreY.Text = configuraciones[index].getNombre().getY().ToString();
            textBoxDireccionX.Text = configuraciones[index].getDireccion().getX().ToString();
            textBoxDireccionY.Text = configuraciones[index].getDireccion().getY().ToString();
            textBoxCiudadX.Text = configuraciones[index].getCiudad().getX().ToString();
            textBoxCiudadY.Text = configuraciones[index].getCiudad().getY().ToString();
            //movimientos
            textBoxYGeneral.Text = configuraciones[index].getConcepto().getY().ToString();
            textBoxCantidadX.Text = configuraciones[index].getCantidad().getX().ToString();
            textBoxConceptoX.Text = configuraciones[index].getConcepto().getX().ToString();
            textBoxPrecioX.Text = configuraciones[index].getPrecio().getX().ToString();
            textBoxImporteX.Text = configuraciones[index].getImporte().getX().ToString();
            textBoxIntelineado.Text = configuraciones[index].getInterlineado().ToString();
            //totales
            textBoxTotalLetraX.Text = configuraciones[index].getTotalLetra().getX().ToString();
            textBoxTotalLetraY.Text = configuraciones[index].getTotalLetra().getY().ToString();
            textBoxTotalNumeroX.Text = configuraciones[index].getTotalNumerico().getX().ToString();
            textBoxTotalNumeroY.Text = configuraciones[index].getTotalNumerico().getY().ToString();
        }

        private void serializaNotas()
        {
            try
            {
                IFormatter formater = new BinaryFormatter();
                Stream stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formater.Serialize(stream, configuraciones);
                stream.Close();
            }
            catch
            {
            }
        }

        private void cambiaConfiguracionNota(object sender, EventArgs e)
        {
            ComboBox combo= (ComboBox)(sender);
            foreach (FormatoNota fn in configuraciones)
            {
                fn.setActivo(false);
            }
            configuraciones[combo.SelectedIndex].setActivo(true);
            cargaValoresNotas(combo.SelectedIndex);
            serializaNotas();
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
            //comboBoxConfAct.Text = configuraciones[combo.SelectedIndex].getNombreConf();
        }
       
        private void clickBtnNuevo(object sender, EventArgs e)
        {
            labelNombreNuevo.Visible = true;
            textBoxNombreNuevo.Visible = true;
            errorNombreConf.Visible = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            quitaErrores();
            reestableceValoresNotas();
            bandNuevo = true;
        }

        private void clickBtnEliminar(object sender, EventArgs e)
        {
            try
            {
                configuraciones.RemoveAt(comboBoxConfAct.SelectedIndex);
                llenaComboBoxNotas();
                reestableceValoresNotas();
                serializaNotas();
            }
            catch
            {
            }
        }

        private void clickBtnGuardar(object sender, EventArgs e)
        {
            if (guardarNota())
            {
                labelNombreNuevo.Visible = false;
                textBoxNombreNuevo.Visible = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
            }
            
        }

        private bool guardarNota()
        {
            bool exito, band;
            FormatoNota nuevo;

            exito = true;
            nuevo = new FormatoNota();
            if (bandNuevo)
            {
                band = validaNombreConf(nuevo);
                if (!band)
                    exito = band;
            }
            band = validaGeneralNotas(nuevo);
            if (!band)
                exito = band;
            band = validaClienteNota(nuevo);
            if (!band)
                exito = band;
            band = validaMovimientosNota(nuevo);
            if (!band)
                exito = band;
            band = validaTotales(nuevo);
            if (!band)
                exito = band;
            if (!exito)
                MessageBox.Show("Errores en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (bandNuevo)
                {
                    configuraciones.Add(nuevo);
                    MessageBox.Show("Guardado con exito", "Aviso!");
                }
                else
                {
                    nuevo.setNombreConf(configuraciones[comboBoxConfAct.SelectedIndex].getNombreConf());
                    nuevo.setActivo(configuraciones[comboBoxConfAct.SelectedIndex].getActivo());
                    configuraciones[comboBoxConfAct.SelectedIndex] = nuevo;
                    MessageBox.Show("Configuracion Modificada", "Aviso!");
                    bandNuevo = false;
                }
                serializaNotas();
                llenaComboBoxNotas();
            }
            return exito;
        }

        private bool validaNombreConf(FormatoNota nuevo)
        {
            bool band, exito,bandCiclo;

            exito = true;
            band = nuevo.setNombreConf(textBoxNombreNuevo.Text);
            exito = marcaError(band, errorNombreConf, exito);
            if (exito)
            {
                bandCiclo=true;
                for (short i = 0; bandCiclo && i < configuraciones.Count; i++)
                {
                    if (string.Compare(configuraciones[i].getNombreConf(), textBoxNombreNuevo.Text.Trim()) == 0)
                        bandCiclo = false;
                }
                if (!bandCiclo)
                    MessageBox.Show("El nombre de la configuracion ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return exito;
        }

        private bool validaGeneralNotas(FormatoNota nuevo)
        {
            bool band, exito = true;

            band = nuevo.setInicio(textBoxInicio.Text);
            exito=marcaError(band, errorInicio, exito);
            nuevo.setNombreFuente(comboBoxFuente.SelectedItem.ToString());
            band = nuevo.setTamFuente(textBoxTamFuente.Text);
            exito = marcaError(band, errorTamFuente, exito);
            band = nuevo.setFecha(textBoxFechaX.Text, textBoxFechaY.Text);
            exito = marcaError(band, errorFecha, exito);
            band = nuevo.setFolio(textBoxFolioX.Text, textBoxFolioY.Text);
            exito = marcaError(band, errorFolio, exito);
            return exito;
        }

        private bool validaClienteNota(FormatoNota nuevo)
        {
            bool band, exito = true;

            band = nuevo.setNombre(textBoxNombreX.Text, textBoxNombreY.Text);
            exito = marcaError(band, errorNombre, exito);
            band = nuevo.setDireccion(textBoxDireccionX.Text, textBoxDireccionY.Text);
            exito = marcaError(band, ErrorDireccion, exito);
            band = nuevo.setCiudad(textBoxCiudadX.Text, textBoxCiudadY.Text);
            exito = marcaError(band, ErrorCiudad, exito);
            return exito;
        }

        private bool validaMovimientosNota(FormatoNota nuevo)
        {
            bool band, exito;

            exito = true;

            band = nuevo.setInterlineado(textBoxIntelineado.Text);
            exito = marcaError(band, errorInterlineado, exito);
            band = nuevo.setCantidad(textBoxCantidadX.Text, textBoxYGeneral.Text);
            exito = marcaError(band, errorCantidadNota, exito);
            marcaError(band, errorYGeneral, exito);
            band = nuevo.setConcepto(textBoxConceptoX.Text, textBoxYGeneral.Text);
            exito = marcaError(band, errorConcepto, exito);
            marcaError(band, errorYGeneral, exito);
            band = nuevo.setPrecio(textBoxPrecioX.Text,textBoxYGeneral.Text);
            exito=marcaError(band,errorPrecio,exito);
            marcaError(band, errorYGeneral, exito);;
            band = nuevo.setImporte(textBoxImporteX.Text, textBoxYGeneral.Text);
            exito = marcaError(band, errorImporte, exito);
            marcaError(band, errorYGeneral, exito);
            return exito;
        }

        private bool validaTotales(FormatoNota nuevo)
        {
            bool band, exito;

            exito = true;
            band = nuevo.setTotalLetra(textBoxTotalLetraX.Text, textBoxTotalLetraY.Text);
            exito = marcaError(band, errorTotalLetraNota, exito);
            band = nuevo.setTotalNumerico(textBoxTotalNumeroX.Text, textBoxTotalNumeroY.Text);
            exito = marcaError(band, errorTotalNumeroNota, exito);
            return exito;
        }

        private bool marcaError(bool bandInsercion, Label error,bool bandExito)
        {
            if (!bandInsercion)
            {
                error.Visible = true;
                return false;
            }
            else
            {
                error.Visible = false;
                return bandExito;
            }
        }
        
        private void clickBtnCancelar(object sender, EventArgs e)
        {
            labelNombreNuevo.Visible = false;
            textBoxNombreNuevo.Visible = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;
            reestableceValoresNotas();
            bandNuevo = false;
        }

        private void cambiaFuenteNota(object sender, EventArgs e)
        {
            labelEjemplo.Font = new Font(comboBoxFuente.SelectedItem.ToString(), 9);
        }

        //fin Notas
        
        //ambos

        private void deserializaListas()
        {
            IFormatter formater = new BinaryFormatter();
            Stream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                configuraciones = (List<FormatoNota>)formater.Deserialize(stream);
            }
            catch
            {
            }
            stream.Close();

            formater = new BinaryFormatter();
            stream = new FileStream(nombreCheque, FileMode.Open, FileAccess.Read, FileShare.Read);
            try
            {
                lstC = (List<FormatoCheque>)formater.Deserialize(stream);
            }
            catch
            {
            }
            stream.Close();
        }

        private void creaArchivos()
        {
            IFormatter formater = new BinaryFormatter();
            Stream stream;
            if (!System.IO.File.Exists(nombreArchivo))
            {
                stream = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formater.Serialize(stream, configuraciones);
                stream.Close();
            }
            formater = new BinaryFormatter();
            if (!System.IO.File.Exists(nombreCheque))
            {
                stream = new FileStream(nombreCheque, FileMode.Create, FileAccess.Write, FileShare.None);
                formater.Serialize(stream, lstC);
                stream.Close();
            }
        }

        private void seleccionConfiguracion(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            actualizaGrupos(boton.Text);
        }

        private void actualizaGrupos(string caso)
        {
            if (caso == "Notas")
            {
                groupNota.Visible = true;
                groupBoxCheques.Visible = false;
                preparaNotas();
                tipo = 1;
                llenaComboBoxNotas();
            }
            else
            {
                groupNota.Visible = false;
                groupBoxCheques.Visible = true;
                preparaCheques();
                tipo = 2;
                llenaComboBoxCheque();
            }
        }

        //cheques

        public FormatoCheque getFormatoChequeActivo()
        {
            foreach (FormatoCheque f in lstC)
            {
                if (f.getActivo())
                    return f;
            }
            return null;
        }

        private void preparaCheques()
        {
            labelNombreNuevoCh.Visible = false;
            textBoxNombreNCheque.Visible = false;
            btnChequeCancelar.Enabled = false;
            btnChequeGuardar.Enabled = false;
            btnNuevoCheque.Enabled = true;
            btnChequeElimina.Enabled = false;
            limpiaErroresCheques();
        }

        private void limpiaErroresCheques()
        {
            erroChequeFuente.Visible = false;
            errorChequeFactura.Visible = false;
            errorChequeFecha.Visible = false;
            errorChequeInicio.Visible = false;
            errorChequeLeyenda.Visible = false;
            errorChequeNombreN.Visible = false;
            errorChequeNomre.Visible = false;
            errorChequeTLetra.Visible = false;
            errorChequeTNumero.Visible = false;
            errerChequeConcepto.Visible = false;
        }

        private void llenaComboBoxCheque()
        {
            bool activo=false;
            comboBoxConfigActiva.Items.Clear();
            if (lstC.Count != 0)
            {
                for (short i = 0; i < lstC.Count; i++)
                {
                    comboBoxConfigActiva.Items.Add(lstC[i].getNombreConf());
                    if (lstC[i].getActivo())
                    {
                        activo= true;
                        comboBoxConfigActiva.SelectedIndex = i;
                    }
                }
            }
            if (activo)
            {
                btnChequeGuardar.Enabled = true;
                btnChequeElimina.Enabled = true;
            }
            else
            {
                btnChequeGuardar.Enabled = false;
                btnChequeElimina.Enabled = false;
            }
        }

        private void serializaCheques()
        {
            try
            {
                IFormatter formater = new BinaryFormatter();
                Stream stream = new FileStream(nombreCheque, FileMode.Create, FileAccess.Write, FileShare.None);
                formater.Serialize(stream, lstC);
                stream.Close();
            }
            catch
            {
            }
        }

        private void cambiaConfigCheque(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)(sender);
            foreach (FormatoCheque f in lstC)
                f.setActivo(false);
            lstC[comboBoxConfigActiva.SelectedIndex].setActivo(true);
            cargaValoresCheque(comboBoxConfigActiva.SelectedIndex);
            btnChequeElimina.Enabled = true;
            btnChequeGuardar.Enabled = true;
            serializaCheques();
        }

        private void cargaValoresCheque(int index)
        {
            textBoxChequeInicio.Text = lstC[index].getInicio().ToString();
            comboBoxChequeFuente.Text = lstC[index].getNombreFuente();
            textBoxChequeTamFuente.Text = lstC[index].getTamFuente().ToString();
            textBoxChequeFechaX.Text = lstC[index].getFecha().getX().ToString();
            textBoxChequeFechaY.Text = lstC[index].getFecha().getY().ToString();
            textBoxChequeFacturaX.Text = lstC[index].getFactura().getX().ToString();
            textBoxChequeFacturaY.Text = lstC[index].getFactura().getY().ToString();
            textBoxChequeLeyendaX.Text = lstC[index].getLeyenda().getX().ToString();
            textBoxChequeLeyendaY.Text = lstC[index].getLeyenda().getY().ToString();
            textBoxChequeNombreX.Text = lstC[index].getNombre().getX().ToString();
            textBoxChequeNombreY.Text = lstC[index].getNombre().getY().ToString();
            textBoxChequeTLetraX.Text = lstC[index].getCantidadLetra().getX().ToString();
            textBoxChequeTLetraY.Text = lstC[index].getCantidadLetra().getY().ToString();
            textBoxChequeTNumeroX.Text = lstC[index].getCantidadNumero().getX().ToString();
            textBoxChequeTNumeroY.Text = lstC[index].getCantidadNumero().getY().ToString();    
        }

        private void limpiaValoresCheque()
        {
            textBoxChequeInicio.Clear();
            textBoxChequeTamFuente.Clear();
            comboBoxChequeFuente.SelectedIndex = 0;
            textBoxChequeFechaX.Clear();
            textBoxChequeFechaY.Clear();
            textBoxChequeFacturaX.Clear();
            textBoxChequeFacturaY.Clear();
            textBoxChequeLeyendaX.Clear();
            textBoxChequeLeyendaY.Clear();
            textBoxChequeNombreX.Clear();
            textBoxChequeNombreY.Clear();
            textBoxChequeTLetraX.Clear();
            textBoxChequeTLetraY.Clear();
            textBoxChequeTNumeroX.Clear();
            textBoxChequeTNumeroY.Clear();
        }

        private void cambiaFuenteCheque(object sender, EventArgs e)
        {
            ejemploFuenteCheque.Font = new Font(comboBoxChequeFuente.SelectedItem.ToString(), 9);
        }

        private void clickBtnNuevoCheque(object sender, EventArgs e)
        {
                limpiaErroresCheques();
                limpiaValoresCheque();
                labelNombreNuevoCh.Visible = true;
                textBoxNombreNCheque.Visible = true;
                btnChequeCancelar.Enabled = true;
                btnChequeGuardar.Enabled = true;
                btnChequeElimina.Enabled = false;
                bandNuevo = true;
        }

        private bool guardaCheque()
        {
           bool band, exito;
            
            FormatoCheque fc;
            fc= new FormatoCheque();

            exito = true;
            band = true;
            band = guardaGeneralCheque(fc);
            if (!band)
                exito = band;
            band = guardaProveedorCheque(fc);
            if (!band)
                exito = band;
            if (bandNuevo)
            {
                band = fc.setNombreConf(textBoxNombreNCheque.Text);
                exito = marcaError(band, errorChequeNombreN, exito);    
            }
            if (!exito)
                MessageBox.Show("Errores en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (bandNuevo)
                {
                    lstC.Add(fc);
                    MessageBox.Show("Guardado con exito", "Aviso!");
                }
                else
                {
                    fc.setNombreConf(lstC[comboBoxConfigActiva.SelectedIndex].getNombreConf());
                    fc.setActivo(lstC[comboBoxConfigActiva.SelectedIndex].getActivo());
                    lstC[comboBoxConfigActiva.SelectedIndex] = fc;
                    MessageBox.Show("Configuracion Modificada", "Aviso!");
                    bandNuevo = false;
                }
                serializaCheques();
                llenaComboBoxCheque();
            }
            return exito;
        }

        private bool guardaGeneralCheque(FormatoCheque fc)
        {
            bool exito, band;
            exito = true;

            exito = true;
            band = fc.setInicio(textBoxChequeInicio.Text);
            exito = marcaError(band, errorChequeInicio, exito);
            band = fc.setNombreFuente(comboBoxChequeFuente.Text);
            exito = marcaError(band, erroChequeFuente, exito);
            band = fc.setTamFuente(textBoxChequeTamFuente.Text);
            exito = marcaError(band, erroChequeFuente, exito);
            band = fc.setFecha(textBoxChequeFechaX.Text, textBoxChequeFechaY.Text);
            exito = marcaError(band, errorChequeFecha, exito);
            band = fc.setFactura(textBoxChequeFacturaX.Text, textBoxChequeFacturaY.Text);
            exito = marcaError(band, errorChequeFactura, exito);
            return exito;
        }

        private bool guardaProveedorCheque(FormatoCheque fc)
        {
            bool exito, band;
            exito = true;

            band = fc.setNombre(textBoxChequeNombreX.Text, textBoxChequeNombreY.Text);
            exito = marcaError(band, errorChequeNomre, exito);
            band = fc.setLeyenda(textBoxChequeLeyendaX.Text, textBoxChequeLeyendaY.Text);
            exito = marcaError(band, errorChequeLeyenda, exito);
            band = fc.setCantidadNumero(textBoxChequeTNumeroX.Text, textBoxChequeTNumeroY.Text);
            exito = marcaError(band, errorChequeTNumero, exito);
            band = fc.setCantidadLetra(textBoxChequeTLetraX.Text, textBoxChequeTLetraY.Text);
            exito = marcaError(band, errorChequeTLetra, exito);
            band = fc.setConcepto(textBoxChequeConceptoX.Text, textBoxChequeConceptoY.Text);
            exito = marcaError(band, errerChequeConcepto, exito);
            return exito;
        }

        private void btnEliminaCheque(object sender, EventArgs e)
        {
            try
            {
                lstC.RemoveAt(comboBoxConfigActiva.SelectedIndex);
                llenaComboBoxCheque();
                limpiaValoresCheque();
                serializaCheques();
            }
            catch
            {
            }
        }

        private void btnGuardaCheque(object sender, EventArgs e)
        {
            if (guardaCheque())
            {
                btnChequeGuardar.Enabled = false;
                btnChequeCancelar.Enabled = false;
                labelNombreNuevoCh.Visible = false;
                textBoxNombreNCheque.Visible = false;
            }
        }

        private void btnCancelaCheque(object sender, EventArgs e)
        {
           labelNombreNuevoCh.Visible = false;
            limpiaErroresCheques();
            limpiaValoresCheque();
            textBoxNombreNCheque.Visible = false;
            btnChequeCancelar.Enabled = false;
            btnChequeGuardar.Enabled = false;
            btnChequeElimina.Enabled = true;
            bandNuevo = false;
        }

    }
}
