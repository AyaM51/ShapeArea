namespace ShapeArea.Tests
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_1_ShouldReturnPi()
        {
            double[] radius = { 1 };
            double expexted = Math.PI;
            double actual = new Circle().GetArea(radius);

            Assert.Equal(expexted, actual);
        }
    }
}
