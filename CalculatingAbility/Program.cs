using System;

namespace CalculatingAbility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbilityScoreCalculator calculator = new AbilityScoreCalculator();
            while (true)
            {
                calculator.RollResult = ReadInt(calculator.RollResult, "Starting 4d6 roll");
                calculator.DivideBy = ReadDouble(calculator.DivideBy, "Divide by");
                calculator.AddAmount = ReadInt(calculator.AddAmount, "Add amount");
                calculator.CalculateAbilityScore();
                Console.WriteLine("Calculated ability score: " + calculator.Score);
                Console.WriteLine("Press Q to quit, any other key to continue");
                char keyChar = Console.ReadKey(true).KeyChar;
                if ((keyChar == 'Q') || (keyChar == 'q')) return;
            }
        }

        private static double ReadDouble(double divideBy, string v)
        {
            Console.WriteLine($"{v} [{divideBy}]: ");
            string prompt = Console.ReadLine();
            if (double.TryParse(prompt, out double value))
                return value;
            else
                return divideBy;
        }

        private static int ReadInt(int rollResult, string v)
        {
            Console.WriteLine($"{v} [{rollResult}]: ");
            string prompt = Console.ReadLine();
            if (int.TryParse(prompt, out int value))
                return value;
            else
                return rollResult;
        }
    }
}
