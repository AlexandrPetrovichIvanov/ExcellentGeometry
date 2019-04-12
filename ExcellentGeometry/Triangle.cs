using System;
using ExcellentGeometry.Utils;

namespace ExcellentGeometry
{
    /// <summary>
    ///     Triangle.
    /// </summary>
    public class Triangle : IShape
    {
        /// <summary>
        ///     Create a new triangle.
        /// </summary>
        public Triangle(double sizeA, double sizeB, double sizeC)
        {
            if (!TriangleInequalityRule.IsSatisfied(sizeA, sizeB, sizeC))
                throw new ArgumentException("Triangle sizes must satisfy \"Triangle inequality rule\".");

            SideA = sizeA;
            SideB = sizeB;
            SideC = sizeC;
        }

        /// <summary>
        ///     Get size A.
        /// </summary>
        public double SideA { get; }

        /// <summary>
        ///     Get size B.
        /// </summary>
        public double SideB { get; }

        /// <summary>
        ///     Get size C.
        /// </summary>
        public double SideC { get; }

        /// <summary>
        ///     Indicates if one of the triangle's angles is a right angle
        ///     (that is, a 90-degree angle).
        /// </summary>
        public bool IsRightTriangle
        {
            get
            {
                var realArea = GetArea();

                // if triangle is a right triangle, area is one of the following: 
                var potentialArea1 = 0.5 * SideA * SideB;
                var potentialArea2 = 0.5 * SideA * SideC;
                var potentialArea3 = 0.5 * SideB * SideC;

                return realArea.IsApproximatelyEqualTo(potentialArea1)
                       || realArea.IsApproximatelyEqualTo(potentialArea2)
                       || realArea.IsApproximatelyEqualTo(potentialArea3);
            }
        }

        /// <inheritdoc />
        public double GetArea() => UseHeronsFormula();

        private double UseHeronsFormula()
        {
            // semiperimeter
            var s = 0.5 * (SideA + SideB + SideC);

            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}