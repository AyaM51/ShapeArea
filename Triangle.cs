namespace ShapeArea
{
    internal class Triangle : IShape
    {
        public string GetShapeName()
        {
            return ShapeNames.Triangle;
        }
        public void ValidateInput(params double[] sides)
        {
            if (sides.Length != 3)
                throw new ArgumentException("triangle must have three 'side' values");

            bool mathValid = (sides[0] + sides[1] > sides[2]) &&
                (sides[1] + sides[2] > sides[0]) &&
                (sides[0] + sides[2] > sides[1]);
            if (!mathValid)
                throw new ArgumentException("triangle with these parameters cannot exist");
        }
        public bool IsRectangular(double maxSide, double side1, double side2)
        {
            if (Math.Pow(maxSide, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2))
                return true;
            else return false;
        }

        public double GetArea(params double[] sides)
        {
            double maxSide = sides.Max();
            int maxSideIndex = Array.IndexOf(sides, maxSide);
            sides = sides.Where((side, index) => index != maxSideIndex).ToArray();
            if (IsRectangular(maxSide, sides[0], sides[1]))
            {
                return (sides[0] * sides[1]) / 2.0;
            }
            else
            {
                double p = (maxSide + sides[0] + sides[1]) / 2.0;
                return Math.Sqrt(p * (p - maxSide) * (p - sides[0]) * (p - sides[1]));
            }
        }
    }
}
