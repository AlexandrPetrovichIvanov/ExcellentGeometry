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
            var triangle = new Triangle(10, 20, 15);
            Console.WriteLine("Triangle is created. Sizes:"
                + $"{triangle.SideA},{triangle.SideB},{triangle.SideC}");

            Console.WriteLine($"Is it a right triangle? {triangle.IsRightTriangle}");

            var circle = new Circle(100);
            Console.WriteLine("Circle is created. "
                + $"Diameter: {circle.Diameter}, radius: {circle.Radius}");

            var totalArea = CalculateTotalArea(new IShape[] {triangle, circle});
            Console.WriteLine($"Total area is: {totalArea}");

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