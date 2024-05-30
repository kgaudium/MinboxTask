using MindboxTask;

namespace MindboxTaskTest;

[TestFixture]
public class AreaCalculatorTests
{
    [Test]
    public void CalculateArea_CircleWithRadius10_Returns100Pi()
    {
        Circle circle = new Circle(10);
        double calculatedArea = AreaCalculator<Circle>.CalculateArea(circle);
        double expectedArea = Math.PI * 100;

        Assert.That( calculatedArea, Is.EqualTo(expectedArea));
    }

    [Test]
    public void CalculateArea_TriangleWithSides3And4And5_Returns6()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        double calculatedArea = AreaCalculator<Triangle>.CalculateArea(triangle);
        double expectedArea = 6;
        
        Assert.That(calculatedArea, Is.EqualTo(expectedArea));
    }
    
    
}