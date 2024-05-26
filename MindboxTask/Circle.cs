namespace MindboxTask;

public class Circle : IHasArea
{
    private double Radius { get; }
    
    public Circle(double radius=1)
    {
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