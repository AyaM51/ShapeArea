namespace ShapeArea
{
    internal static class Utilites
    {
        public static void CheckZeroNegative(params double[] sides)
        {
            if (sides.Length==0)
                throw new ArgumentException("empty value are not allowed");
            double exp = 0.000000001;
            foreach (double s in sides)
            {
                if (Math.Abs(s) < exp) 
                    throw new ArgumentException("zero values are not allowed");
                if (s < 0) 
                    throw new ArgumentException("negative values are not allowed");
            }
        }
    }
}
