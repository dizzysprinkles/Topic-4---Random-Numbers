using Microsoft.VisualBasic;

namespace Topic_4___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randomInteger, max, min, firstRoll, secondRoll,sumRolls, roundValue;
            double randomDouble, number;

            //Random Integer Generator
            Console.WriteLine("Hey there! Give me a maximum value and a minimum value and I'll generate you five random numbers!\nMax number is: ");
            Int32.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("Min number is: ");
            Int32.TryParse(Console.ReadLine(), out min);
            Console.WriteLine();

            // Max/Min check
            if (max < min)
            {
                Console.WriteLine("Not possible... The maximum is bigger than the minimum.");
            }
            else
            {
                Console.WriteLine("And the five random numbers are...");
                for (int i = 1; i <= 5; i++)
                {
                    randomInteger = generator.Next(min, max + 1);
                    Console.Write(randomInteger + " ");
                }

                //Dice Rolls
                Console.WriteLine();
                Console.WriteLine("How about I roll some dice for you? ");
                Console.WriteLine();

                firstRoll = generator.Next(1, 7);
                secondRoll = generator.Next(1, 7);
                sumRolls = firstRoll + secondRoll;
                Console.WriteLine($"The first roll was a {firstRoll} and the second roll was a {secondRoll}. The sum of those two numbers is {sumRolls}.");

                //Random Decimal Generator
                Console.WriteLine();
                Console.WriteLine("What about a decimal generator? I'll generate three random numbers with the maximum and minimum you gave me!\nHow many decimals should I round to?");
                Int32.TryParse(Console.ReadLine(), out roundValue);

                Console.WriteLine();
                Console.WriteLine("And those three random decimals are...");

                for (int i = 1; i <= 3; i++)
                {
                    randomInteger = generator.Next(min, max);
                    randomDouble = generator.NextDouble();
                    number = randomDouble + randomInteger;
                    Console.Write(Math.Round(number, roundValue) + " ");
                }
                randomDouble = generator.NextDouble();
                Console.WriteLine();
            }

           

        }
    }
}
