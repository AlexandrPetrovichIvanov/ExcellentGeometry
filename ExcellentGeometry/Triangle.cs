using System;

namespace ExcellentGeometry
{
    /// <summary>
    ///     Triangle.
    /// </summary>
    public class Triangle : IShape
    {
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