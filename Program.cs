namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question1(args);
            Question2(args);
        }

        static void Question1(string[] args)
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
        static void Question2(string[] args)
        {
            Console.WriteLine("enter an integer greater than 1:");
            int Number = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            int X = 2;
            while (Number > 1)
            {
                bool multi = false;
                while (Number % X == 0) //while 2 is a factor of Number
                {
                    if (!multi)
                    {
                        Console.WriteLine(X); // X is the prime factor
                    }
                    count = count + 1; //counting the number of prime factors
                    multi = true;
                    Number = Number / X;


                }
                X = X + 1; //moves on to the next possible prime factor
            }
            Console.WriteLine("Total number of prime factors is: " + count);
        }

        static void Question3(string[] args)
        {
            
        }
    }
}



