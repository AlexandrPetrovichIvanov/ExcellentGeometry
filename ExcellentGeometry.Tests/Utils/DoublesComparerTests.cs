using ExcellentGeometry.Utils;
using NUnit.Framework;

namespace ExcellentGeometry.Tests.Utils
{
    public class DoublesComparerTests
    {
        [TestCase(1.0001, 1.0001, DoublesComparer.DefaultPrecision, true)]
        [TestCase(1.334 * 34.27, 5.396 * 8.4722349, 0.001, true)] // we don't expect default precision to be so accurate
        [TestCase(0, 0, DoublesComparer.DefaultPrecision, true)]
        [TestCase(1.344, 2.7, DoublesComparer.DefaultPrecision, false)]
        [TestCase(-1.3434, -1.3434, DoublesComparer.DefaultPrecision, true)]
        public void ComparesDoubles(
            double first,
            double second,
            double precision,
            bool expectedToBeEqual)
        {
            Assert.That(
                first.IsApproximatelyEqualTo(second),
                Is.EqualTo(expectedToBeEqual));
        }

        [Test]
        public void DefaultPrecisionIsNotTooSmall()
        {
            var tooSmallPrecision = 0.01;

            var first = 2.5;
            var second = first + tooSmallPrecision;

            Assert.That(first.IsApproximatelyEqualTo(second), Is.False);
        }

        [Test]
        public void CustomPrecisionWorksCorrectly()
        {
            Assert.That(0.015.IsApproximatelyEqualTo(0.019), Is.False);

            var customPrecision = 0.01;
            Assert.That(0.015.IsApproximatelyEqualTo(0.019, customPrecision),
                Is.True);
        }
    }
}