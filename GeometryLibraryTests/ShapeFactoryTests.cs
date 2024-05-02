using GeometryLibrary.Core;
using GeometryLibrary.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLibraryTests
{
    [TestFixture]
    public class ShapeFactoryTests
    {
        [Test]
        public void CreateCircle_ValidRadius_ReturnsCircle()
        {
            var circle = ShapeFactory.CreateShape("circle", 5) as Circle;
            Assert.IsNotNull(circle);
            Assert.AreEqual(5, circle.Radius);
        }

        [Test]
        public void CreateTriangle_ValidSides_ReturnsTriangle()
        {
            var triangle = ShapeFactory.CreateShape("triangle", 3, 4, 5) as Triangle;
            Assert.IsNotNull(triangle);
            Assert.IsTrue(triangle.IsRightAngled());
        }

        [Test]
        public void CreateShape_UnknownShape_ThrowsNotImplementedException()
        {
            Assert.Throws<NotImplementedException>(() => ShapeFactory.CreateShape("pentagon", 1, 1, 1, 1, 1));
        }
    }
}
