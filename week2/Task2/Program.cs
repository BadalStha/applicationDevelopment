namespace Task2;

class Circle
{
    
    public const double PI = 3.14;
    
    public static double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }

    public static double CalculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //Circle.PI = 1.1;
        
        // It will get compilation error because a constant value can not be modfied once it is defines.

        double radius = 5;
        
        double area = Circle.CalculateArea(radius);
        double perimeter = Circle.CalculatePerimeter(radius);
        
        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);
        
    }
}