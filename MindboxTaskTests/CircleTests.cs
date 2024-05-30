using MindboxTask;

namespace MindboxTaskTest;

[TestFixture]
public class CircleTests
{
    [Test]
    public void Circle_NegativeRadius_ThrowsArgumentException()
    {
        double negativeRadius = -10;
        void ExceptionCircleCreation () => new Circle(negativeRadius);
        
        Assert.That(ExceptionCircleCreation, Throws.ArgumentException);
    }

    [Test]
    // Не уверен насчёт неймнига, но, наверное, это просто в команде оговаривается
    // В данном проекте, буду придерживаться такого нейминга
    public void GetArea_Radius10_Returns10Pi()
    {
        Circle circle = new Circle(10);
        double calculatedArea = circle.GetArea();  // используем метод круга, а не калькулятора площади т.к. тест для круга
        double expectedArea = Math.PI * 100;

        Assert.That( calculatedArea, Is.EqualTo(expectedArea));
    }

    [Test]
    public void GetArea_ZeroRadius_ReturnsZero()
    {
        Circle circle = new Circle(0);
        double calculatedArea = circle.GetArea();

        Assert.That(calculatedArea, Is.Zero);
    }
}