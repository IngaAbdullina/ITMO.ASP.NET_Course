using System;

namespace ASP_Web_MVC.Models
{
    public class Triangle : Shape
    {
        public Triangle(double a, double b, double c)
        {
            St = a;
            Stb = b;
            Stc = c;
        }

        public double Stb { get; set; }
        public double Stc { get; set; }


        override public string Name => String.Format("\"Треугольник со сторонами {0}, {1} и {2}\"", St, Stb, Stc);

        public double Perimeter => Math.Round(St + Stb + Stc);

        public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - St) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
    }
}