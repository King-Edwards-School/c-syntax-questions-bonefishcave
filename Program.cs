namespace Console_Blank_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Question1(args);
            //Question2(args);
            Question3(args);
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
            
        }
    }
}



