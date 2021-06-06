using System;

namespace GuessingGame
{
    public static class Utilities
    {
        public static int ChooseRandomInteger()
        {
            Console.WriteLine("A random number has been chosen.");
            return new Random().Next(1, 100);
        }

        public static int RequestUserInput()
        {
            Console.Write("Type your guess (1-100): ");
            var input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 100) throw new ArgumentOutOfRangeException();
            return input;
        }

        public static void RequestExitCommand()
        {
            Console.Write("Press to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
