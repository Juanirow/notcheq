using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notchec
{
    class Movimiento
    {

        private string concepto;
        private double cantidad, costo, importe;
        private int iD;

        public Movimiento()
        {
            iD = 0;
            concepto = "";
            cantidad = 0;
            costo = 0.0;
            importe = 0.0;
        }


        public bool setCantidad(string newCantidad)
        {
            double valor;
            bool retorno;
            try
            {
                valor = Convert.ToDouble(newCantidad);
                cantidad = valor;
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public double getCantidad()
        {
            return cantidad;
        }

        public double getCosto()
        {
            return costo;
        }

        public bool setCosto(string newCosto)
        {
            double valor;
            bool retorno;
            try
            {
                valor = Convert.ToDouble(newCosto);
                costo = valor;
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public double getImporte()
        {
            return importe;
        }

        public bool setImporte(string newImporte)
        {
            double valor;
            bool retorno;
            try
            {
                valor = Convert.ToDouble(newImporte);
                importe = valor;
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public int getId()
        {
            return iD;
        }

        public bool setID(string newID)
        {
            int valor;
            bool retorno;
            try
            {
                valor = Convert.ToInt32(newID);
                iD = valor;
                retorno = true;
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }

        public string getConcepto()
        {
            return concepto;
        }

        public bool setConcepto(string newConsepto)
        {
            if (newConsepto.Trim().Length == 0)
                return false;
            else
            {
                concepto = newConsepto;
                return true;
            }
        }

    }
}
