using System;

namespace ExcellentGeometry
{
    /// <summary>
    ///     Circle.
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        ///     Create new circle.
        /// </summary>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius must be a positive value.");

            Radius = radius;
        }

        /// <summary>
        ///     Get diameter of the circle.
        /// </summary>
        public double Diameter => Radius * 2;

        /// <summary>
        ///     Get radius of the circle.
        /// </summary>
        public double Radius { get; }

        /// <inheritdoc />
        public double GetArea() => Math.PI * Radius * Radius;
    }
}