namespace ShapeArea
{
    internal class Circle : IShape
    {
        public string GetShapeName()
        {
            return ShapeNames.Circle;
        }
        public void ValidateInput(params double[] radius)
        {
            if (radius.Length != 1) throw new ArgumentException("circle must have one 'radius' value");
        }
        public double GetArea(params double[] radius)
        {
            return Math.PI * Math.Pow(radius[0], 2);
        }
    }
}
