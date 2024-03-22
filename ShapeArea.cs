using System.Runtime.CompilerServices;
[assembly: InternalsVisibleToAttribute("ShapeArea.Tests")]

namespace ShapeArea
{
    public interface IShape
    {
        public string GetShapeName();

        public void ValidateInput(params double[] sides);
        public double GetArea(params double[] sides);
    }

    public static class ShapeNames
    {
        public const string Circle = "circle";
        public const string Triangle = "triangle";
    }    
    
}
