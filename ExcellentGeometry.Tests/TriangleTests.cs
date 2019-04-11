using System;
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
            throw new NotImplementedException();
        }

        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        public void DoesNotAllowZeroSizes(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            throw new NotImplementedException();
        }

        [TestCase(1, 1, 1, 10)]
        [TestCase(1, 1, 1, 10)]
        [TestCase(1, 1, 1, 10)]
        public void CalculatesAreaCorrectly(
            double sizeA,
            double sizeB,
            double sizeC,
            double expectedArea)
        {
            throw new NotImplementedException();
        }

        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue)]
        [TestCase(0.0000000000001, 0.0000000000001, 0.0000000000001)]
        public void CanCopeWithExtremeValuesOfSizes(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            throw new NotImplementedException();
        }
    }
}
