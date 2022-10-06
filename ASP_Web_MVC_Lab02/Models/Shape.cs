using System;

namespace ASP_Web_MVC.Models
{
    public class Shape
    {
        public double St { get; set; }

        virtual public string Name
        {
            get { return String.Format("\"Фигура\""); }
        }
    }
}