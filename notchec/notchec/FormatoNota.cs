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
    [Serializable]
    class FormatoNota
    {
        Punto fecha, nombre, direccion, ciudad;
        Punto cantidad, concepto, precio, importe;
        double  interlineado,inicio;
        Punto totalLetra, totalNumerico,folio;
        bool activo;
        string nombreConf;
        string tipoFuente;
        int tamFuente;


        public FormatoNota()
        {
            fecha = new Punto();
            folio = new Punto();
            nombre = new Punto();
            direccion = new Punto();
            ciudad = new Punto();
            cantidad = new Punto();
            concepto = new Punto();
            precio = new Punto();
            importe = new Punto();
            totalLetra = new Punto();
            totalNumerico = new Punto();
            interlineado = 0.0;
            inicio = 0.0;
            activo = false;
            nombreConf = "";
            tipoFuente = "Arial";
            tamFuente = 9;
        }

        public int getTamFuente()
        {
            return tamFuente;
        }

        public bool setTamFuente(string y)
        {
            int valor;
            try
            {
                valor = Convert.ToInt32(y.Trim());
                tamFuente = valor;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool setNombreFuente(string nuevo)
        {
            if (nuevo.Trim().Length > 0)
            {
                tipoFuente = nuevo.Trim();
                return true;
            }
            else
                return false;
        }

        public string getTipoFuente()
        {
            return tipoFuente;
        }

        public bool setNombreConf(string nuevo)
        {
            if (nuevo.Trim().Length > 0)
            {
                nombreConf = nuevo.Trim();
                return true;
            }
            else
                return false;
        }

        public string getNombreConf()
        {
            return nombreConf;
        }

        public void setActivo(bool newBand)
        {
            activo = newBand;
        }

        public bool getActivo()
        {
            return activo;
        }

        public Punto getFecha()
        {
            return fecha;
        }

        public bool setFecha(string x,string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                fecha = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getFolio()
        {
            return folio;
        }

        public bool setFolio(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                folio = new Punto(valorX, valorY);
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

        public bool setNombre(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                nombre = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getDireccion()
        {
            return direccion;
        }

        public bool setDireccion(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                direccion = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getCiudad()
        {
            return ciudad;
        }

        public bool setCiudad(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                ciudad = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getCantidad()
        {
            return cantidad;
        }

        public bool setCantidad(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                cantidad = new Punto(valorX, valorY);
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

        public bool setConcepto(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                concepto = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getPrecio()
        {
            return precio;
        }

        public bool setPrecio(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                precio = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getImporte()
        {
            return importe;
        }

        public bool setImporte(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                importe = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getTotalLetra()
        {
            return totalLetra;
        }

        public bool setTotalLetra(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                totalLetra = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Punto getTotalNumerico()
        {
            return totalNumerico;
        }

        public bool setTotalNumerico(string x, string y)
        {
            double valorX, valorY;
            try
            {
                valorX = Convert.ToDouble(x.Trim());
                valorY = Convert.ToDouble(y.Trim());
                totalNumerico = new Punto(valorX, valorY);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double getInterlineado()
        {
            return interlineado;
        }

        public bool setInterlineado(string y)
        {
            double valor;
            try
            {
                valor= Convert.ToDouble(y.Trim());
                interlineado = valor;
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

        public bool setInicio(string y)
        {
            double valor;
            try
            {
                valor = Convert.ToDouble(y.Trim());
                inicio = valor;
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
