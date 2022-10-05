using System;

namespace ASP_Web_MVC.Models
{
    public class Triangle
    {
        public Triangle(double a, double b, double c)
        {
            Sta = a;
            Stb = b;
            Stc = c;
        }

        public double Sta { get; set; }
        public double Stb { get; set; }
        public double Stc { get; set; }

        public string Name => $"\"Треугольник со сторонами {Sta}, {Stb} и {Stc}\"";

        public double Perimeter => Math.Round(Sta + Stb + Stc);

        public double Area => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - Sta) * (Perimeter / 2 - Stb) * (Perimeter / 2 - Stc));
    }
}