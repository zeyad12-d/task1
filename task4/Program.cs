namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the tamperture to celsius");
            double celsius= Convert.ToDouble(Console.ReadLine());
            double fahrentheit = celsius * (1.8) + 32;
            Console.WriteLine($" the temperture in fahernrtheit={ fahrentheit} !");


        }
    }
}
