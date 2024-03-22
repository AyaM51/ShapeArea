using Microsoft.VisualStudio.TestPlatform.Common.Utilities;

namespace ShapeArea.Tests
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void GetAreaBySides_InvalidShapeName_ShouldThrowExeption()
        {
            double[] sides = { 3, 1, 1 };

            Assert.Throws<NullReferenceException>(() => new AreaCalculator().GetAreaBySides("",3, 1, 1));
        }

        [Fact]
        public void GetAreaBySides_Triangle_ValidParams_ShouldReturnValue()
        {
            double[] sides = { 1, 1, 1 };
            double expexted = 0.4330127018922193;
            double actual = new AreaCalculator().GetAreaBySides("triangle",sides);

            Assert.Equal(expexted, actual);
        }

        [Fact]
        public void AddUserShape_ExistingShapeName_ShouldThrowExeption()
        {
            Triangle user_shape = new Triangle();

            Assert.Throws<InvalidOperationException>(() => new AreaCalculator().AddUserShape(user_shape));
        }

        [Fact]
        public void AddUserShape_EmptyShapeName_ShouldThrowExeption()
        {
            EmptyNameShape user_shape = new EmptyNameShape();

            Assert.Throws<InvalidOperationException>(() => new AreaCalculator().AddUserShape(user_shape));
        }

        [Fact]
        public void AddUserShape_SuccessAdd()
        {
            IShape user_shape = new CustomZeroShape();
            var calc = new AreaCalculator();
            calc.AddUserShape(user_shape);
        }


        [Fact]
        public void AddUserShape_SuccessAdd_AndCall()
        {
            IShape user_shape = new CustomZeroShape();
            var fakeSides = new double[]{ 1,2,2};
            var calc=new AreaCalculator();
            calc.AddUserShape(user_shape);
            var res=calc.GetAreaBySides(user_shape.GetShapeName(),fakeSides);
            Assert.Equal(0, res);
        }

    }

    public class EmptyNameShape : IShape
    {
        public string GetShapeName() {
            return "";
        }

        public void ValidateInput(params double[] sides)
        {

        }
        public double GetArea(params double[] sides)
        {
            return 0;
        }

    }

    public class CustomZeroShape : IShape
    {
        public string GetShapeName()
        {
            return "test";
        }

        public void ValidateInput(params double[] sides)
        {
            return;
        }
        public double GetArea(params double[] sides)
        {
            return 0;
        }

    }
}
