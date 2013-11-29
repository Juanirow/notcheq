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
    partial class print : Form
    {
        Font f;
        Configuracion conf;
        FormatoNota formatoNota;
        FormatoCheque formatoCheque;
        Nota n;
        Cheque ch;
        string tipo;
        Moneda m;

        public print()
        {
            InitializeComponent();
            f = new Font("Arial", 9);
            conf = new Configuracion(" ");
            m = new Moneda();
        }

        public void imprimir(Nota nota)
        {
            formatoNota = conf.getFormatoNotaActual();
            if (formatoNota != null)
            {
                tipo = "Nota";
                n = nota;
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.DocumentName = "Imprimiendo Nota";
                    printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                    printDocument1.Print();
                }
            }
            else
                MessageBox.Show("No cuentas con una configuracion seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void imprimir(Cheque cheque)
        {
            formatoCheque = conf.getFormatoChequeActivo();
            {
                if (formatoCheque != null)
                {
                    tipo = "Cheque";
                    ch = cheque;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.DocumentName = "Imprimiendo Cheque";
                        printDocument1.PrinterSettings.PrinterName = printDialog1.PrinterSettings.PrinterName;
                        printDocument1.Print();
                    }
                }
                else
                {
                    MessageBox.Show("No cuentas con una configuracion seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void imprimeCheque(System.Drawing.Printing.PrintPageEventArgs e)
        {
            Point puntoTexto, puntoConv;
            Punto puntoMov = new Punto();
            string texto;
            double inicio;
            Brush brocha = new SolidBrush(Color.Black);
            Font fuente;
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;

            fuente = new Font(formatoCheque.getNombreFuente(), formatoCheque.getTamFuente());
            inicio = formatoCheque.getInicio();
            
            //cantidad numero
            texto = valorMoneda(ch.getCantidad());
            puntoConv = convierteAMilimetros(formatoCheque.getCantidadNumero(), inicio);
            puntoTexto = regresaPuntoAlinFinal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //cantidad letra
            texto = m.Convertir(ch.getCantidad().ToString(),false);
            puntoConv = convierteAMilimetros(formatoCheque.getCantidadLetra(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //fecha
            texto = regresaFecha(ch.getFecha());
            puntoConv = convierteAMilimetros(formatoCheque.getFecha(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //Nombre
            texto = ch.getNombre();
            puntoConv = convierteAMilimetros(formatoCheque.getNombre(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);

            //factura
            texto = ch.getFactura().ToString();
            puntoConv = convierteAMilimetros(formatoCheque.getFactura(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            if (ch.getEsPoliza())
            {
                //Concepto
                texto = ch.getConcepto();
                puntoConv = convierteAMilimetros(formatoCheque.getConcepto(), inicio);
                puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
                e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            }
            if (ch.getLeyenda())
            {
                texto = "Para abono en cuenta \n del Beneficiario";
                puntoConv = convierteAMilimetros(formatoCheque.getLeyenda(), inicio);
                puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, new Font(fuente.SystemFontName, 9), texto, e);
                e.Graphics.DrawString(texto, new Font(fuente.SystemFontName, 9), brocha, puntoTexto);

            }

        }

        private void imprimeNota(System.Drawing.Printing.PrintPageEventArgs e)
        {

            Point puntoTexto, puntoConv;
            Punto puntoMov = new Punto();
            string texto;
            double inicio;
            Brush brocha = new SolidBrush(Color.Black);
            Font fuente;
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;

            fuente = new Font(formatoNota.getTipoFuente(), formatoNota.getTamFuente());
            inicio = formatoNota.getInicio();
          // e.Graphics.DrawString("prueba de inicio", fuente, brocha, new Point(0, 0));
            //numNota
            texto = n.getFolio().ToString();
            puntoConv = convierteAMilimetros(formatoNota.getFolio(), inicio);
            puntoTexto = regresaPuntoAlinFinal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //Fecha
            texto = regresaFecha(n.getFecha());
            puntoConv = convierteAMilimetros(formatoNota.getFecha(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //Nombre
            texto = n.getCliente().getNombre();
            puntoConv = convierteAMilimetros(formatoNota.getNombre(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //direccion
            texto = n.getCliente().getDireccion().ToString();
            puntoConv = convierteAMilimetros(formatoNota.getDireccion(), inicio);
            puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            //Movimientos
            for (int i = 0; i < n.getLista().Count; i++)
            {
                //cantidad
                texto = n.getLista()[i].getCantidad().ToString() + "     ";
                puntoMov.setDoubleX(formatoNota.getCantidad().getX().ToString());
                puntoMov.setDoubleY((formatoNota.getCantidad().getY() + (formatoNota.getInterlineado() * i)).ToString());
                puntoConv = convierteAMilimetros(puntoMov, inicio);
                puntoTexto = regresaPuntoAlinFinal(puntoConv.X, puntoConv.Y, fuente, texto, e);
                e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
                //descripcion
                texto = n.getLista()[i].getConcepto().ToString();
                puntoMov.setDoubleX(formatoNota.getConcepto().getX().ToString());
                puntoMov.setDoubleY((formatoNota.getConcepto().getY() + (formatoNota.getInterlineado() * i)).ToString());
                puntoConv = convierteAMilimetros(puntoMov, inicio);
                puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
                e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
                //precio
                if (n.getBandPrecio())
                {
                    texto = valorMoneda(n.getLista()[i].getCosto());
                    puntoMov.setDoubleX(formatoNota.getPrecio().getX().ToString());
                    puntoMov.setDoubleY((formatoNota.getPrecio().getY() + (formatoNota.getInterlineado() * i)).ToString());
                    puntoConv = convierteAMilimetros(puntoMov, inicio);
                    puntoTexto = regresaPuntoAlinFinal(puntoConv.X, puntoConv.Y, fuente, texto, e);
                    e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
                }
                //importe
                texto = valorMoneda(n.getLista()[i].getImporte());
                puntoMov.setDoubleX(formatoNota.getImporte().getX().ToString());
                puntoMov.setDoubleY((formatoNota.getImporte().getY() + (formatoNota.getInterlineado() * i)).ToString());
                puntoConv = convierteAMilimetros(puntoMov, inicio);
                puntoTexto = regresaPuntoAlinFinal(puntoConv.X, puntoConv.Y, fuente, texto, e);
                e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            }
            //Total Letra
            if (n.getBandLetra())
            {
                texto = m.Convertir(n.getTotal().ToString(), false);
                puntoConv = convierteAMilimetros(formatoNota.getTotalLetra(), inicio);
                puntoTexto = regresaPuntoAlinNormal(puntoConv.X, puntoConv.Y, fuente, texto, e);
                e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
            }
            //total cantidad 
            texto = valorMoneda(n.getTotal());
            puntoConv = convierteAMilimetros(formatoNota.getTotalNumerico(), inicio);
            puntoTexto = regresaPuntoAlinFinal(puntoConv.X, puntoConv.Y, fuente, texto, e);
            e.Graphics.DrawString(texto, fuente, brocha, puntoTexto);
        }

        private string valorMoneda(double valor)
        {
            string ret;

            ret = String.Format("{0:C}", valor);
            return ret;
        }

        private string regresaFecha(DateTime date)
        {
            string nueva;

            nueva = date.Day.ToString() + " / ";
            nueva += mesLetra(date.Month) + " / ";
            nueva += date.Year.ToString();
            return nueva;
        }

        private string mesLetra(int mes)
        {
            string letra=mes.ToString();
            switch (mes)
            {
                case 1:
                    letra= "enero";
                break;
                case 2:
                    letra= "febrero";
                break;
                case 3:
                    letra = "marzo";
                break;
                case 4:
                    letra = "abril";
                break;
                case 5:
                    letra = "mayo";
                break;
                case 6:
                    letra = "junio";
                break;
                case 7:
                    letra = "julio";
                break;
                case 8:
                    letra = "agosto";
                break;
                case 9:
                    letra = "septiembre";
                break;
                case 10:
                    letra = "octubre";
                break;
                case 11:
                    letra = "noviembre";
                break;
                case 12:
                letra = "diciembre";
                break;
            }
            return letra;
        }


        private Point regresaPuntoAlinFinal(int xfin, int yfin, Font fuente, string texto,System.Drawing.Printing.PrintPageEventArgs e)
        {
            int ancho, alto;

            ancho = anchoCadena(fuente, texto,e);
            alto = altoCadena(fuente, texto,e);
            return new Point(xfin - ancho, yfin - alto);
        }

        private Point regresaPuntoAlinNormal(int xfin, int yfin, Font fuente, string texto, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int  alto;
            alto = altoCadena(fuente, texto, e);
            return new Point(xfin, yfin - alto);
        }

        private Point convierteAMilimetros(Punto p,double inicio)
        {
            int x, y;

            x =(int) (p.getX() * 10);
            y = (int)((p.getY()-inicio) * 10);
            return new Point(x, y);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            if (tipo == "Nota")
                imprimeNota(e);
            else
                imprimeCheque(e);

        }

        private int anchoCadena(Font fuente, string texto, System.Drawing.Printing.PrintPageEventArgs e)
        {
            return (int)e.Graphics.MeasureString(texto, fuente).Width;
        }

        private int altoCadena(Font fuente, string texto, System.Drawing.Printing.PrintPageEventArgs e)
        {
            return (int)e.Graphics.MeasureString(texto, fuente).Height;
        }


    }
}
