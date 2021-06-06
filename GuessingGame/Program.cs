using System;
using System.Collections.ObjectModel;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var targetNumber = Utilities.ChooseRandomInteger();
            var gameWon = false;
            Console.WriteLine(targetNumber);

            int? previousGuess = null;

            while (!gameWon)
            {
                try
                {
                    var guess = Utilities.RequestUserInput();

                    if (targetNumber == guess)
                    {
                        Console.WriteLine("You got it!");
                        gameWon = true;
                    } else
                    {
                        var currentGuessDifference = Math.Abs(targetNumber - guess);

                        if (previousGuess.HasValue)
                        {
                            if (previousGuess.Value == guess)
                            {
                                Console.WriteLine("Error: You have entered the same number!");
                                continue;
                            }

                            var previousGuessDifference = Math.Abs(previousGuess.Value - targetNumber);

                            if (currentGuessDifference < previousGuessDifference)
                            {
                                Console.WriteLine("Hotter");
                            } else
                            {
                                Console.WriteLine("Colder");
                            }
                        } else
                        {
                            if (currentGuessDifference < 11)
                            {
                                Console.WriteLine("Hot");
                            }
                            else
                            {
                                Console.WriteLine("Cold");
                            }
                        }

                        previousGuess = guess;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: Input was not a number.");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("ERROR: Input needs to be between 1 to 100.");
                }
            }

            Utilities.RequestExitCommand();
        }
    }
}
