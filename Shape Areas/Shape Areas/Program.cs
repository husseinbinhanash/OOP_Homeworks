

class Shape
{
    public virtual double CalculateArea()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return 3.14 * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Circle { Radius = 5 },
            new Rectangle { Width = 4, Height = 6 }
        };

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetType());
            Console.WriteLine("Area : " + s.CalculateArea());
            Console.WriteLine("-------------");
        }

        Console.ReadLine();
    }
}