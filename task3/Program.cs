namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter your birth your");
            double age=Convert.ToDouble(Console.ReadLine());
            double currentyear = 2024;
            double yourage = currentyear - age;
            Console.WriteLine($"your age = {yourage} ");



                }
    }
}
