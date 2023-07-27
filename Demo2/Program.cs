namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program to print all the odd numbers between 1 and 100
            int I = 0;

            while (I <=100)
            {
                if(I % 2 == 1)
                {
                    Console.WriteLine(I);
                }
                I++;
            }
        }
    }
}