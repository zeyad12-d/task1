using System.Transactions;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("enter the first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the secand number");
            int num2=Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int difference=num1 - num2;
            int product= num1 * num2;
            int divison = num1 / num2;
            Console.WriteLine($"sum{sum}");
            Console.WriteLine($"diff{difference} ");
            Console.WriteLine($"pro{product}");
            Console.WriteLine($"div{divison}");


        }
    }
}
