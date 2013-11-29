using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notchec
{
    class Cheque
    {
        double cantidad;
        int factura;
        string nombre;
        bool leyenda, esPagare;
        DateTime fecha;
        string concepto;

        public Cheque()
        {
            cantidad = 0.0;
            factura = 0;
            nombre = "";
            leyenda = false;
            esPagare = false;
            fecha = new DateTime();
            concepto = "";
        }

        public string getConcepto()
        {
            return concepto;
        }

        public void setConcepto(string texto)
        {
            concepto = texto;
        }

        public void setDate(DateTime newDate)
        {
            fecha = newDate;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public bool setCantidad(string newValor)
        {
            try
            {
                cantidad = Convert.ToDouble(newValor.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public bool setFactura(string newValor)
        {
            try
            {
                factura = Convert.ToInt32(newValor.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getFactura()
        {
            return factura;
        }

        public bool setNombre(string newNombre)
        {
            if (newNombre.Trim().Length != 0)
            {
                nombre = newNombre;
                return true;
            }
            else
                return false;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setLeyenda(bool newBand)
        {
            leyenda = newBand;
        }

        public bool getLeyenda()
        {
            return leyenda;
        }

        public void setEsPagare(bool newBand)
        {
            esPagare = newBand;
        }

        public bool getEsPoliza()
        {
            return esPagare;
        }
    }
}
