namespace MindboxTask;

public class Circle : IHasArea
{
    private double Radius { get; }
    
    public Circle(double radius=1)
    {
        // Есть ли смысл в таком ограничении? Зависит от контекста)
        if (radius < 0)
            throw new ArgumentException($"Radius can't be negative, given: {radius}");
        
        Radius = radius;
    }
    
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public override string ToString()
    {
        return $"Circle (radius={Radius})";
    }
}