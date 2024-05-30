using MindboxTask;

namespace MindboxTaskTest;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void Triangle_NegativeSide_ThrowsArgumentException()
    {
        double side = 10;
        void ExceptionTriangleCreation() => new Triangle(side, -side, -side);
        
        Assert.That(ExceptionTriangleCreation, Throws.ArgumentException);
    }

    [Test]
    public void GetArea_Sides3And4And5_Returns25()
    {
        // Насчёт использования var или полного названия типа, я тоже думаю, что это скорее оговаривается в команде
        // А так, просто предпочтения самого программиста
        Triangle triangle = new Triangle(3, 4, 5);
        double calculatedArea = triangle.GetArea();
        double expectedArea = 6;
        
        Assert.That(calculatedArea, Is.EqualTo(expectedArea));
    }

    [Test]
    public void GetArea_EqualSides_ReturnsCorrectArea()
    {
        double side = 10;
        Triangle triangle = new Triangle(side, side, side);
        double calculatedArea = triangle.GetArea();
        double expectedArea = Math.Sqrt(15 * 125);
        
        Assert.That(calculatedArea, Is.EqualTo(expectedArea));
    }

    [Test]
    public void GetPerimeter_Sides10And20And30_Returns60()
    {
        Triangle triangle = new Triangle(10, 20, 30);
        double calculatedPerimeter = triangle.GetPerimeter();
        double expectedPerimeter = 60;
        
        Assert.That(calculatedPerimeter, Is.EqualTo(expectedPerimeter));
    }

    [Test]
    public void IsRightTriangle_Sides3And4And5_ReturnsTrue()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        bool calculatedValue = triangle.IsRightTriangle();
        
        Assert.That(calculatedValue, Is.True);
    }
    
    [Test]
    public void IsRightTriangle_EqualSides_ReturnsFalse()
    {
        double side = 10;
        Triangle triangle = new Triangle(side, side, side);
        bool calculatedValue = triangle.IsRightTriangle();
        
        Assert.That(calculatedValue, Is.False);
    }
    
    [Test]
    public void GetSides_Sides8And2And5_ReturnsSidesInDescendingOrder()
    {
        Triangle triangle = new Triangle(8, 2, 5);
        double[] actualValue = triangle.GetSides();

        bool firstIs8 = actualValue[0] == 8;
        bool secondIs5 = actualValue[1] == 5;
        bool thirdIs2 = actualValue[2] == 2;

        bool isDescendingOrder = firstIs8 && secondIs5 && thirdIs2;
        
        Assert.That(isDescendingOrder, Is.True);
    }
}