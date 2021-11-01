using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration_2
{
    public abstract class Shape
    {
        public string ShapeType { get; set; }


        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>Returns hard coded value</returns>
        public virtual double CalculateArea(double num1, double num2)
        {
            Console.WriteLine("Error 1");
            return 0;
        }

        /// <summary>
        /// Calculates the circumference.
        /// </summary>
        /// <returns>Returns hard coded value</returns>
        public virtual double CalculateCircumference(double num1, double num2)
        {
            Console.WriteLine("Error 2");
            return 0;
        }

        /// <summary>
        /// Template for subclasses to be able to output a string
        /// </summary>
        /// <returns>Returns a string</returns>
        public override string ToString()
        {
            return $"The circumference of a {ShapeType} is {CalculateCircumference(1, 1)} and the area is {CalculateArea(1, 1)}.";
        }
    }
}
