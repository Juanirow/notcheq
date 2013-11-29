using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace notchec
{
    [Serializable]
    class Punto
    {
        double x, y;

        public Punto()
        {
            x = 0;
            y = 0;
        }

        public Punto(double xNew, double yNew)
        {
            x = xNew;
            y = yNew;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public bool setDoubleX(string newX)
        {
            try
            {
                x = Convert.ToDouble(newX.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool setDoubleY(string newY)
        {
            try
            {
                y = Convert.ToDouble(newY.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
