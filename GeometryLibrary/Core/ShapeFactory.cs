using GeometryLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibrary.Core
{
    public class ShapeFactory
    {
        public static Shape CreateShape(string shapeType, params double[] args)
        {
            switch (shapeType.ToLower())
            {
                case "circle":
                    return new Circle(args[0]);
                case "triangle":
                    return new Triangle(args[0], args[1], args[2]);
                default:
                    throw new NotImplementedException("Shape type not recognized.");
            }
        }
    }
}
