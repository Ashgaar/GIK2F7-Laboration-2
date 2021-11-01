using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    public class Triangle : Shape, IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle()
        {
            //Imagine a triangle where A is the side to the left, Base is the side at the bottom
            //and the hypotenuse is C.
            Base = 5;
            Height = 6;
            A = 7;
            C = 8;
            ShapeType = "triangle";
        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>Returns value from calculation</returns>
        public override double CalculateArea(double num1, double num2)
        {
            return Base * Height / 2;
        }

        /// <summary>
        /// Calculates the circumference.
        /// </summary>
        /// <returns>Returns value from calculation</returns>
        public override double CalculateCircumference(double num1, double num2)
        {
            return A + Base + C;
        }
    }
}
