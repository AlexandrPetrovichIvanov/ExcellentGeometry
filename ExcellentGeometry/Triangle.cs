using System;

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
            SizeA = sizeA;
            SizeB = sizeB;
            SizeC = sizeC;

            // check "triangle rule"
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Get size A.
        /// </summary>
        public double SizeA { get; }

        /// <summary>
        ///     Get size B.
        /// </summary>
        public double SizeB { get; }

        /// <summary>
        ///     Get size C.
        /// </summary>
        public double SizeC { get; }

        /// <summary>
        ///     Indicates if one of the triangle's angles is a right angle
        ///     (that is, a 90-degree angle).
        /// </summary>
        public bool IsRightTriangle => throw new NotImplementedException();

        /// <inheritdoc />
        public double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}