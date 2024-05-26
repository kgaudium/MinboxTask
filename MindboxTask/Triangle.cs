namespace MindboxTask;

public class Triangle : IHasArea
{
    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double GetArea()
    {
        if (IsRightTriangle())
        {
            var sides = GetSides();
            return sides[1] * sides[2] * 0.5;
        }
        
        double semiPerimeter = GetPerimeter() / 2;
        double mult = semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3);
        return Math.Sqrt(mult);
    }

    public double GetPerimeter()
    {
        return Side1 + Side2 + Side3;
    }

    public bool IsRightTriangle()
    {
        var sides = GetSides();
        double diff = Math.Pow(sides[0], 2) - (Math.Pow(sides[1], 2) + Math.Pow(sides[2], 2));
        return Math.Abs(diff) < 1e-10;
    }

    public double[] GetSides()
    {
        double[] sides = [Side1, Side2, Side3];
        return sides.OrderDescending().ToArray();
    }

    public override string ToString()
    {
        string rightStr = IsRightTriangle() ? "Right " : "";
        return  rightStr + $"Triangle (Side1={Side1}, Side2={Side2}, Side3={Side3})";
    }
}