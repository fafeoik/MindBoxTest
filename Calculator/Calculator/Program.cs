using Areas.Implementations;

class Program
{
    static void Main(string[] args)
    {
        AreaCalculator circle = new AreaCalculator(new CircleAreaCalculator(4));
        AreaCalculator triangle = new AreaCalculator(new TriangleAreaCalculator(2,2,3));
        Console.WriteLine(circle.Calculate());
        Console.WriteLine(triangle.Calculate());
    }
}

