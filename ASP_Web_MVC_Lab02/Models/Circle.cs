using System;

namespace ASP_Web_MVC.Models
{
    public class Circle : Shape, IComparable<Circle>
    {
        override public string Name
        {
            get
            {
                return String.Format("\"Окружность с радиусом {0}\"", St);
            }
        }

        public Circle(double a)
        {
            St = a;
        }
        public double Dlina
        {
            get
            {
                double p = 2 * Math.PI * St;
                return p;
            }
        }
        public double Area
        {
            get
            {
                double sq = Math.PI * St * St;
                return sq;
            }
        }

        public int CompareTo(Circle other)
        {
            if (this.Area == other.Area) return 0;
            else if (this.Area > other.Area) return 1;
            else return -1;
        }
    }
}