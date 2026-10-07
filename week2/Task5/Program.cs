namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        
        DateTime birthDate =  new DateTime(2006, 08, 20);
        DateTime currentDate= DateTime.Now;
        
        TimeSpan age = currentDate - birthDate;
        
        int ageInYears = (int)(age.TotalDays / 365);

        String display = $"Birth Date: {birthDate:yyyy-MM-dd}\n" +
                         $"Current Date: {currentDate:yyyy-MM-dd}\n" +
                         $"Age: {ageInYears}";
        
        Console.WriteLine(display);
        DateTime convertBirthDate = birthDate.AddYears(10);
        Console.WriteLine($"Converted Birthdate: {convertBirthDate:yyyy-MM-dd}" );
    }
}