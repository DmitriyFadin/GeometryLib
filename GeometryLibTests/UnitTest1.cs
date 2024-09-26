using GeometryLib;
using GeometryLib.Shapes;

namespace GeometryLibTests;

public class Tests
{

    [Test]
    public void CircleAreaTest()
    {
        var circle = new Circle(5);
        double expectedArea = Math.PI * 25;
        Assert.AreEqual(expectedArea, circle.GetArea());
    }

    [Test]
    public void TriangleAreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        Assert.AreEqual(triangle.GetArea(), expectedArea);
    }

    [Test]
    public void RightAngledTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightAngled());
    }

    [Test]
    public void InvalidTriangleTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 10));
    }

    [Test]
    public void AreaTest()
    {
        var triangle = new Triangle(3, 4, 5);
        var circle = new Circle(5);

        var TriangleArea = ShapeAreaCalculator.CalculateArea(triangle);
        var CircleArea = ShapeAreaCalculator.CalculateArea(circle);

        Assert.AreEqual(TriangleArea, 6);
        Assert.AreEqual(CircleArea, Math.PI * 25);
    }
}
