namespace CircleLab;

public class Circle
{
    private double radius { get; set; }
    public double CalculateDiameter()
    {
        return 2 * radius;
    }
    public double CalculateCircumfurence()
    {
        return 2* System.Math.PI * radius;
    }
    public double CalculateArea()
    {
        return System.Math.PI * System.Math.Pow(radius, 2);
    }
    public void Grow()
    {
        radius = radius * 2;
    }
    public double GetRadius()
    {
        return radius;
    }
    public Circle (double radius)
    {
        this.radius = radius;
    }
}
