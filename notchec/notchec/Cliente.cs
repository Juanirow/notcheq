using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notchec
{
    [Serializable]
    class Cliente
    {
        string nombre;
        string direccion;
        string ciudad;

        public Cliente()
        {
            nombre = " ";
            direccion = " ";
            ciudad = " ";
        }

        public bool setNombre(string nuevoValor)
        {
            if (nuevoValor.Trim().Length > 0)
            {
                nombre = nuevoValor;
                return true;
            }
            else
                return false;
        }

        public string getNombre()
        {
            return nombre;
        }

        public bool setDireccion(string nuevoValor)
        {
            if (nuevoValor.Trim().Length > 0)
            {
                direccion = nuevoValor;
                return true;
            }
            else
                return false;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public bool setCiudad(string nuevoValor)
        {
            if (nuevoValor.Trim().Length > 0)
            {
                ciudad = nuevoValor;
                return true;
            }
            else
                return false;
        }

        public string getCiudad()
        {
            return ciudad;
        }
        
    }
}
