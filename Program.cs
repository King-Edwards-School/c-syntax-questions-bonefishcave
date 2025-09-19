namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args) // call subroutines in main
        {
            Question1(args);
            Question2(args);
            Question3(args);
            Question4(args);
            Question5(args);
            Question6(args);
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
                    Console.Write("X");
                }
                else
                {
                    if (Count % 5 == 0)
                    {
                        Console.Write("V");
                    }
                    else
                    {
                        Console.Write("/");
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

        static void Question3(string[] args) // this block finds all of the consecutive numbers that factor into the user input
        {

            Console.WriteLine("Enter an integer greater than 1:");
            int X = Convert.ToInt32(Console.ReadLine());
            int Product = 1;
            int Factor = 0;

            while (Product < X)
            {
                Factor++;
                Product = Product * Factor; // cycling through until prodct is made greater than or equal to the user input
            }
            if (X == Product) // once x is made equal to the product
            {
                Product = 1;                       //factor represents the largest number that goes into user input
                for (int N = 1; N <= Factor; N++) // continues while n is less than or equal to factor
                {
                    Product = Product * N; // this works by finding the largest number that factors into user input
                    Console.WriteLine(N);
                }

            }
            else
            {
                Console.WriteLine("No result"); // there is no combination of consecutive integers that factor into the user input 
            }
        }

        static void Question4(string[] args)
        {

            Console.WriteLine("Enter an integer (0-99):");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculate additive or multiplicative persistence? (A/M)");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string Operation = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            int count = 0;
            while (value > 9)
            {
                if (Operation == "A")
                {
                    value = value / 10 + value % 10;
                }
                else
                {
                    value = (value / 10) * (value % 10);
                }
                count++;
            }
            Console.WriteLine("The persistence is:");
            Console.WriteLine(count);
        }

        static void Question5(string[] args) // this converts base 10 to binary
        {

            Console.WriteLine("Enter a positive whole number for binary conversion: ");
            int NumberIn = Convert.ToInt32(Console.ReadLine());

            int NumberOut = 0;
            int PartValue = 0;

            int Count = 0;
            while (NumberIn > 0)
            {
                Count++;
                PartValue = NumberIn % 2;
                NumberIn = NumberIn / 2;
                for (int i = 1; i < Count; i++)
                {
                    PartValue = PartValue * 10;
                }
                NumberOut = NumberOut + PartValue;
            }
            Console.WriteLine("The result is " + NumberOut);
        }

        static void Question6(string[] args) // this simulates rolling two dice until either a six is rolled three times, or a double is rolled three times
        {
            Thread.Sleep(3000);

            int C = 0;
            int D = 0;
            int S = 0;
            int T = 0;
            int A;

            Random roll1 = new Random();
            Random roll2 = new Random();

            while (C < 3 && D < 3)
            {
                T++;
                int N1 = roll1.Next(1, 6);
                int N2 = roll2.Next(1, 6);
                Console.WriteLine(N1 + " " + N2);
                S = S + N1 + N2;
                if (N1 == 6 || N2 == 6)
                {
                    C++; // C is the number of times a six rolls
                }
                if (N1 == N2)
                {
                    D++;
                }
                A = S / (T * 2);
                Console.WriteLine("6 was rolled " + C + " times, " + "Doubles were rolled " + D + " times " + "and average roll was " + A);

            }
        }
    }
}



