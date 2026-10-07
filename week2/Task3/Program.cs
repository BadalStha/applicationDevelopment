namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        byte num1 = 1;
        short num2 = 2;
        int num3 = 42;
        long num4 = 4;
        float num5 = 5.0f;
        double num6 = 6.0;
        decimal num7 = 7.0m;
        char alpha = 'A';
        bool state = true;
        string pi = "3.14";
        
        string convertInt = num3.ToString();
        double convertString = double.Parse(pi);

        string display = $"Byte value: {num1}\n" +
                         $"Short value: {num2}\n" +
                         $"Int value: {num3}\n" +
                         $"Long value: {num4}\n" +
                         $"Float value: {num5}\n" +
                         $"Double value: {num6}\n" +
                         $"Decimal value: {num7}\n" +
                         $"Char value: {alpha}\n" +
                         $"bool value: {state}\n" +
                         $"String value: {pi}\n" +
                         $"Int Converted To String: {convertInt}\n" +
                         $"String Converted To Double: {convertString}\n"; 
        
        Console.WriteLine(display);
    }
}