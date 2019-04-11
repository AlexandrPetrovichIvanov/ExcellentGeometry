using NUnit.Framework;

namespace ExcellentGeometry.Tests
{
    public class TriangleTests
    {
        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void DoesNotAllowNegativeSizes(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            Assert.That(() => new Triangle(sizeA, sizeB, sizeC),
                Throws.Exception);
        }

        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void DoesNotAllowZeroSizes(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            Assert.That(() => new Triangle(sizeA, sizeB, sizeC),
                Throws.Exception);
        }

        [TestCase(3, 4, 5, 6)]
        public void CalculatesAreaCorrectly(
            double sizeA,
            double sizeB,
            double sizeC,
            double expectedArea)
        {
            var triangle = new Triangle(sizeA, sizeB, sizeC);
            Assert.That(triangle.GetArea().IsApproximatelyEqualTo(expectedArea));
        }

        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue)]
        [TestCase(0.0000000000001, 0.0000000000001, 0.0000000000001)]
        public void CanCopeWithExtremeValuesOfSizes(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            var triangle = new Triangle(sizeA, sizeB, sizeC);
            Assert.That(() => triangle.GetArea(), Throws.Nothing);
        }
    }
}
