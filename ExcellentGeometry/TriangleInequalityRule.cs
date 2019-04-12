namespace ExcellentGeometry
{
    internal static class TriangleInequalityRule
    {
        internal static bool IsSatisfied(
            double sizeA,
            double sizeB,
            double sizeC)
        {
            return sizeA + sizeB > sizeC
                   && sizeA + sizeC > sizeB
                   && sizeB + sizeC > sizeA;
        }
    }
}