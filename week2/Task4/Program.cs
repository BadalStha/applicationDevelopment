namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        int[] favNumbers = new int[]{ 3, 7, 14, 6, 2 };
        
        Array.Sort(favNumbers);
        Array.Reverse(favNumbers);

        for (int i = 0; i < favNumbers.Length; i++)
        {
            Console.WriteLine(favNumbers[i]);
        }

        int exactIndex = Array.IndexOf(favNumbers, 14);
        Console.WriteLine(exactIndex);
    }
}