namespace MindboxTask;

public static class AreaCalculator<T> where T : IHasArea
{
    // Используем генерик для получения типа в compile time
    // Если бы использовался обычный класс, то тип определялся бы в runtime
    public static double CalculateArea(T hasArea)
    {
        return hasArea.GetArea();
    }
}