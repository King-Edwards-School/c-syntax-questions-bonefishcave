namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another Integer:");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            int Number = 0;

            if (Number1 > Number2)
            {
                int temp = Number1 / Number2;
                Number = temp;
            }
            else
            {
                int temp = Number2 / Number1;
                Number = temp;
            }

            int Count = 0;
            while (Count != Number)
            {
                Count++;
                if (Count % 10 == 0)
                {
                    Console.WriteLine("X");
                }
                else
                {
                    if (Count % 5 == 0)
                    {
                        Console.WriteLine("V");
                    }
                    else
                    {
                        Console.WriteLine("/");
                    }
                }
            }

        }
    }
}