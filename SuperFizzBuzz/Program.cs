using System;

namespace SuperFizzBuzz
{
    /// <summary>
    /// This program has not input validations, just some business logic validations to get the goal
    /// </summary>
    class Program
    {
        static string _num1, _num2;
        static void Main(string[] args)
        {
            Console.WriteLine("START PROGRAM \n");

            StartProgram();

            Console.WriteLine("END PROGRAM \n");
            Console.ReadKey();
        }

        static void StartProgram() 
        {
            Console.Clear();
            Console.WriteLine("Choose the program you want to run: ");
            Console.WriteLine("1) Classic FizzBuzz");
            Console.WriteLine("2) Advance SuperFizzBuzz");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    CommonMessages();
                    ClassicFizzBuzz();
                    break;
                case "2":
                    CommonMessages();
                    AdvanceFizzBuzz();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
            }
        }

        static void CommonMessages() 
        {
            Console.Write("Enter the init range number: ");
            _num1 = Console.ReadLine();

            Console.Write("Enter the end range number: ");
            _num2 = Console.ReadLine();
        }

        static void ClassicFizzBuzz() 
        {
            var aResult = new SuperFizzBuzz(_num1, _num2, 1).RunClassic();
            ReadResults(aResult);
            TryAgain();
        }

        static void AdvanceFizzBuzz()
        {
            string[] divisors = new string[3];
            string[] tokens = null;
 
            Console.WriteLine("Default tokens are 'Frog', 'Duck', 'Chicken'. Do you want to replace them for new ones? (Y/N)");
            if (Console.ReadLine().ToUpper() == "Y") 
            {
                tokens = new string[3];
                Console.Write("Enter first token: ");
                tokens[0] = Console.ReadLine();
                Console.Write("Enter second token: ");
                tokens[1] = Console.ReadLine();
                Console.Write("Enter third token: ");
                tokens[2] = Console.ReadLine();
            }

            Console.Write("Enter first divisor: ");
            divisors[0] = Console.ReadLine();
            Console.Write("Enter second divisor: ");
            divisors[1] = Console.ReadLine();
            Console.Write("Enter third divisor: ");
            divisors[2] = Console.ReadLine();

            var aResult = new SuperFizzBuzz(_num1, _num2, 2, divisors, tokens).RunAdvance();
            ReadResults(aResult);
            TryAgain();
        }

        static void ReadResults(string[] aResult) 
        {
            Array.ForEach(aResult, item => Console.WriteLine(item));
        }

        static void TryAgain() 
        {
            Console.WriteLine("Do you want to try again (Y/N):");
            if (Console.ReadLine().ToUpper() == "Y")
                StartProgram();
            else
                Environment.Exit(0);
        }
    }
}
