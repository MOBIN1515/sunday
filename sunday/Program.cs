namespace sunday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("please enter number1 ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter number2 ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int div = num1 % num2;
            Console.WriteLine("your divisible number are :" + div);

            if(div==0)
            {
                Console.WriteLine("your numbers are divisible");

            }
            else
            {
                Console.WriteLine("your numbers are not divisible");

            }
            Console.ReadKey();

        }
    }
}
