using GeometryLibrary.Core;
using GeometryLibrary.Shapes;

var circle = ShapeFactory.CreateShape("Circle", 2) as Circle;

Console.WriteLine(circle.CalculateArea());

var triangle = ShapeFactory.CreateShape("Triangle", 6, 8, 10) as Triangle;
Console.WriteLine(triangle.CalculateArea());
Console.WriteLine(triangle.IsRightAngled());

