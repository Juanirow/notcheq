using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notchec
{
    [Serializable]
    class FormatoCheque
    {
        Punto cantidadNumero, fecha, factura;
        Punto cantidadLetra, nombre, leyenda;
        string nomConf;
        int tamFuente;
        string nombreFuente;
        bool activo;
        double inicio;
        Punto concepto;

        public FormatoCheque()
        {
            tamFuente = 9;
            nombreFuente = "Arial";
            cantidadLetra = new Punto();
            inicio = 0.0;
            fecha = new Punto();
            factura = new Punto();
            cantidadNumero = new Punto();
            leyenda = new Punto();
            nombre = new Punto();
            nomConf = "";
            activo = false;
            concepto = new Punto();
        }

        public bool setConcepto(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                concepto = new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getConcepto()
        {
            return concepto;
        }

        public bool setTamFuente(string valor)
        {
            try
            {
                tamFuente = Convert.ToInt32(valor.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getTamFuente()
        {
            return tamFuente;
        }

        public bool setNombreFuente(string valor)
        {
            if (valor.Trim().Length > 0)
            {
                nombreFuente = valor.Trim();
                return true;
            }
            else
                return false;
        }

        public string getNombreFuente()
        {
            return nombreFuente;
        }

        public bool setInicio(string valor)
        {
            try
            {
                inicio = Convert.ToDouble(valor.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double getInicio()
        {
            return inicio;
        }

        public bool getActivo()
        {
            return activo;
        }

        public void setActivo(bool newBand)
        {
            activo = newBand;
        }

        public string getNombreConf()
        {
            return nomConf;
        }

        public bool setNombreConf(string valor)
        {
            if (valor.Trim().Length > 0)
            {
                nomConf = valor.Trim();
                return true;
            }
            else
                return false;
        }

        public bool setLeyenda(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                leyenda = new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getLeyenda()
        {
            return leyenda;
        }

        public bool setNombre(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                nombre= new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getNombre()
        {
            return nombre;
        }

        public bool setFactura(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                factura = new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getFactura()
        {
            return factura;
        }

        public bool setFecha(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                fecha = new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getFecha()
        {
            return fecha;
        }

        public bool setCantidadNumero(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                cantidadNumero = new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getCantidadNumero()
        {
            return cantidadNumero;
        }

        public bool setCantidadLetra(string x, string y)
        {
            double valX, valY;
            try
            {
                valX = Convert.ToDouble(x);
                valY = Convert.ToDouble(y);
                cantidadLetra = new Punto(valX, valY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getCantidadLetra()
        {
            return cantidadLetra;
        }
    }
}
