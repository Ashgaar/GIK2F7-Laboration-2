using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    public class Rectangle : Shape, IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 5;
            Width = 6;
            ShapeType = "rectangle";
        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>Returns value from calculation</returns>
        public override double CalculateArea(double num1, double num2)
        {
            return Length * Width;
        }

        /// <summary>
        /// Calculates the circumference.
        /// </summary>
        /// <returns>Returns value from calculation</returns>
        public override double CalculateCircumference(double num1, double num2)
        {
            return Length * 2 + Width * 2;
        }
    }
}
