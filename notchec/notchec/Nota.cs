using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notchec
{
    class Nota
    {
        Cliente cliente;
        string folio;
        double totalNumerico;
        List<Movimiento> lstMov;
        DateTime fecha;
        bool bandPrecio,bandLetra;

        public Nota()
        {
            cliente = new Cliente();
            folio = "";
            totalNumerico = 0.0;
            lstMov = new List<Movimiento>();
            fecha = new DateTime();
            bandPrecio = false;
            bandLetra = false;
        }

        public void setBandLetra(bool newBand)
        {
            bandLetra = newBand;
        }

        public bool getBandLetra()
        {
            return bandLetra;
        }

        public void setBandPrecio(bool newBand)
        {
            bandPrecio = newBand;
        }

        public bool getBandPrecio()
        {
            return bandPrecio;
        }

        public void setFecha(DateTime date)
        {
            fecha = date;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public void setListaMov(List<Movimiento> mov)
        {
            lstMov = mov;
        }

        public List<Movimiento> getLista()
        {
            return lstMov;
        }

        public void setTotalNumerico(double total)
        {
            totalNumerico = total;
        }

        public double getTotal()
        {
            return totalNumerico;
        }

        public void setCliente(Cliente nuevo)
        {
            cliente = nuevo;
        }

        public Cliente getCliente()
        {
            return cliente;
        }

        public void setFolio(string nuevoFolio)
        {
            folio = nuevoFolio;
        }

        public string getFolio()
        {
            return folio;
        }


    }
}
