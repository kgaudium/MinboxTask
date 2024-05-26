namespace MindboxTask;

public static class AreaCalculator
{
    public static double CalculateArea(IHasArea hasArea)
    {
        return hasArea.GetArea();
    }
}