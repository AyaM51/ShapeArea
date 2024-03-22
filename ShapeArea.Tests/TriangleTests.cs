namespace ShapeArea.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void ValidateInput_3_1_1_ShouldThrowExeption()
        {
            double[] sides = { 3, 1, 1 };

            Assert.Throws<ArgumentException>(()=>new Triangle().ValidateInput(3,1,1));
        }

        [Fact]
        public void IsRectangular_5_4_3_ShouldReturnTrue()
        {
            double maxSide = 5;
            double side1 = 4;
            double side2 = 3;

            Assert.True(new Triangle().IsRectangular(maxSide, side1, side2));
        }

        [Fact]
        public void IsRectangular_4_3_2_ShouldReturnFalse()
        {
            double maxSide = 4;
            double side1 = 3;
            double side2 = 2;

            Assert.False(new Triangle().IsRectangular(maxSide, side1, side2));
        }

        [Fact]
        public void IsRectangular_1_1_1_ShouldReturnFalse()
        {
            double maxSide = 1;
            double side1 = 1;
            double side2 = 1;

            Assert.False(new Triangle().IsRectangular(maxSide, side1, side2));
        }

        [Fact]
        public void GetArea_1_1_1_ShouldReturnValue()
        {
            double[] sides = { 1, 1, 1 };
            double expexted = 0.4330127018922193;
            double actual = new Triangle().GetArea(sides);

            Assert.Equal(expexted, actual);
        }

    }
}
