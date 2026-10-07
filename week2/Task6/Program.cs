namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        List<string> favFruits = new() { "Mango", "Litchi", "Orange" };

        favFruits.Add("Apple");
        favFruits.Remove("Litchi");

        foreach (var favFruit in favFruits)
        {
            Console.WriteLine(favFruit);
        }

        Dictionary<int, string> fruits = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Orange" },
            { 3, "Mango" }
        };

        // Add a new entry
        fruits.Add(4, "Litchi");

        // Print all key-value pairs
        foreach (KeyValuePair<int, string> fruit in fruits)
        {
            Console.WriteLine("ID: " + fruit.Key + ", Fruit: " + fruit.Value);
        }
    }
}