using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    public class Circle : Shape, IShape
    {
        public double Pi { get; set; }
        public double Radius { get; set; }

        public Circle()
        {
            Pi = Math.PI;
            Radius = 7;
            ShapeType = "circle";
        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>Returns value from calculation</returns>
        public override double CalculateArea(double num1, double num2)
        {
            return Pi * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Calculates the circumference.
        /// </summary>
        /// <returns>Returns value from calculation</returns>
        public override double CalculateCircumference(double num1, double num2)
        {
            return 2 * Pi * Radius;
        }
    }
}
