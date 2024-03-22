namespace ShapeArea.Tests
{
    public class UtilitesTests
    {

        [Fact]
        public void CheckZeroNegative_NegativeNumber_ShouldThrowException()
        {
            double[] sides = { 1.0, -1.0, 2.0 };

            Assert.Throws<ArgumentException>(()=>Utilites.CheckZeroNegative(sides));
        }

        [Fact]
        public void CheckZeroNegative_Zero_ShouldThrowException()
        {
            double[] sides = { 1.0, 0, 2.0 };

            Assert.Throws<ArgumentException>(() => Utilites.CheckZeroNegative(sides));
        }

        [Fact]
        public void CheckZeroNegative_EmptyArray_ShouldThrowException()
        {
            double[] sides = { };

            Assert.Throws<ArgumentException>(() => Utilites.CheckZeroNegative(sides));
        }

        [Fact]
        public void CheckZeroNegative_NearZero_ShouldThrowException()
        {
            double[] sides = { 1.0, 1e-10, 2.0 };

            Assert.Throws<ArgumentException>(() => Utilites.CheckZeroNegative(sides));
        }
    }
}