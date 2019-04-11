namespace ExcellentGeometry.Tests
{
    internal static class DoublesComparer
    {
        /// <summary>
        ///     It's not a real accuracy. Just for comparing doubles.
        /// </summary>
        private const double SomeAccuracy = 0.000001;

        internal static bool IsApproximatelyEqualTo(this double first, double second)
        {
            return first >= second - SomeAccuracy
                   && first <= second + SomeAccuracy;
        }
    }
}