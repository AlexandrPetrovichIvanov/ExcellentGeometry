using System;
using ExcellentGeometry.Utils;
using NUnit.Framework;

namespace ExcellentGeometry.Tests
{
    public class CircleTests
    {
        [Test]
        public void DoesNotAllowNegativeRadius()
        {
            Assert.That(() => new Circle(-1), Throws.Exception);
        }

        [Test]
        public void DoesNotAllowZeroRadius()
        {
            Assert.That(() => new Circle(0), Throws.Exception);
        }

        [Test]
        public void CalculatesDiameter()
        {
            var radius = 1;
            var circle = new Circle(radius);

            Assert.That(circle.Diameter.IsApproximatelyEqualTo(2));
        }

        [TestCase(33, Math.PI * 33 * 33)]
        public void CalculatesArea(double radius, double expectedArea)
        {
            var circle = new Circle(radius);

            Assert.That(circle.GetArea().IsApproximatelyEqualTo(expectedArea));
        }

        [TestCase(double.MaxValue)]
        [TestCase(0.000000000001d)]
        public void CanCopeWithExtremeValuesOfRadius(double radius)
        {
            var circle = new Circle(radius);

            Assert.That(() => circle.Diameter, Throws.Nothing);
            Assert.That(() => circle.GetArea(), Throws.Nothing);
        }
    }
}
