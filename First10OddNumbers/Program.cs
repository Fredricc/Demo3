namespace First10OddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program to print the first 10 odd numbers
            int I = 0;
            int counter = 1;
            Console.WriteLine("Top 10 Odd Numbers");

            while (I <= 100 && counter <= 10)
            {
                if (I % 2 == 1)
                {
                    Console.WriteLine($"{counter}  -  {I}");
                    counter++;
                }
                I++;
            }
        }
    }
}