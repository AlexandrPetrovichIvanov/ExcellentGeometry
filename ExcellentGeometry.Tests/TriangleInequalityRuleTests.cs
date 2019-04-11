using NUnit.Framework;

namespace ExcellentGeometry.Tests
{
    public class TriangleInequalityRuleTests
    {
        [Test]
        public void OrdinaryTriangleSatisfiesTheRule()
        {
            Assert.That(TriangleInequalityRule.IsSatisfied(15, 25, 20));
        }

        [TestCase(10, 10, 100)]
        [TestCase(10, 100, 10)]
        [TestCase(100, 10, 10)]
        [TestCase(20, 10, 10)]
        [TestCase(10, 20, 10)]
        [TestCase(10, 10, 20)]
        public void DefinesIfSizesDoNotSatisfyTheRuleCorrectly(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            Assert.That(TriangleInequalityRule.IsSatisfied(sizeA, sizeB, sizeC),
                Is.False);
        }
    }
}