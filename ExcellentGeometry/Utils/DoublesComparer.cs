namespace ExcellentGeometry.Utils
{
    /// <summary>
    ///     Compares <see cref="double" /> values with the given precision.
    /// </summary>
    public static class DoublesComparer
    {
        /// <summary>
        ///     Default precision used in comparing operations.
        /// </summary>
        public const double DefaultPrecision = 0.000001;

        /// <summary>
        ///     Indicates that the first double is approximately equal
        ///     to the second one.
        /// </summary>
        public static bool IsApproximatelyEqualTo(
            this double first,
            double second,
            double precision = DefaultPrecision)
        {
            return first >= second - precision
                   && first <= second + precision;
        }
    }
}