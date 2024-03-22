using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public class AreaCalculator
    {
        private Dictionary<string, IShape> shapes = new()
        {
            { ShapeNames.Circle, new Circle() },
            { ShapeNames.Triangle, new Triangle() },
        };
        public double GetAreaBySides(string shape_type, params double[] sides)
        {
            if (!shapes.ContainsKey(shape_type)) throw new NullReferenceException("shape does not exist");
            Utilites.CheckZeroNegative(sides);
            shapes[shape_type].ValidateInput(sides);
            return shapes[shape_type].GetArea(sides);
        }

        public void AddUserShape(IShape s)
        {
            if (String.IsNullOrEmpty(s.GetShapeName()))
            {
                throw new InvalidOperationException("shape must have name");
            }
            if (shapes.ContainsKey(s.GetShapeName()))
            {
                throw new InvalidOperationException("shape already exist");
            }
            shapes.Add(s.GetShapeName(), s);
        }
    }
}
