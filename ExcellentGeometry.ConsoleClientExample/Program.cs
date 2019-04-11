using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcellentGeometry.ConsoleClientExample
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Code in the method ExampleClientCode is an example of using ExcellentGeometry library.");
            ExampleClientCode();
        }

        private static void ExampleClientCode()
        {
            var triangle = new Triangle();
            var circle = new Circle();

            var totalArea = CalculateTotalArea(new IShape[] {triangle, circle});

            Console.WriteLine($"Total area is: {totalArea}");

            Console.WriteLine();
            Console.WriteLine($"Is it a right triangle? {triangle.IsRightTriangle}");

            Console.ReadLine();
        }

        private static double CalculateTotalArea(IEnumerable<IShape> shapes)
        {
            return shapes.Sum(shape =>
            {
                var area = shape.GetArea();
                Console.WriteLine($"Area of {shape.GetType().Name} is {area}");
                return area;
            });
        }
    }
}