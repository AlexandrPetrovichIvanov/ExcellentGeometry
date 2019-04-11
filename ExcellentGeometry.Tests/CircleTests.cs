using System;
using NUnit.Framework;

namespace ExcellentGeometry.Tests
{
    public class CircleTests
    {
        [Test]
        public void DoesNotAllowNegativeRadius()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void DoesNotAllowZeroRadius()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void CalculatesDiameter()
        {
            throw new NotImplementedException();
        }

        [TestCase(1d, 2.555)]
        [TestCase(1d, 2.555)]
        [TestCase(1d, 2.555)]
        public void CalculatesArea(double radius, double expectedArea)
        {
            throw new NotImplementedException();
        }

        [TestCase(double.MaxValue)]
        [TestCase(0.000000000001d)]
        public void CanCopeWithExtremeValuesOfRadius(double radius)
        {
            throw new NotImplementedException();
        }
    }
}
