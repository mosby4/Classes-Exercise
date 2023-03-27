namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var MyCar = new Cars();
            MyCar.Make = "Aerial Atom";
            MyCar.Model = "Atom Four";
            MyCar.Year = 2023;
            Console.WriteLine($"My new race car is an {MyCar.Make}.");
            Console.WriteLine($"More specifcly a {MyCar.Year }  {MyCar.Model}.");
        }
    }
}
