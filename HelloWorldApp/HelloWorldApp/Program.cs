namespace HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num1, num2;
            Console.WriteLine("Write two number for sum : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("multiplication of " + num1 + " and " + num2 + " is : " + multiplication(num1, num2));
        }

        //function for sum of two numbers
        public static int multiplication(int num1,int num2)
        {
            int total =  num1 * num2;
            return total;
        }
    }
}