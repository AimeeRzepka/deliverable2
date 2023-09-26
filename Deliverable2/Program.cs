// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;
					
public class Program
{
    public static void Main()
    {
        {
            Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
            Console.WriteLine("What is your name?");
            string Name = (Console.ReadLine());
            int score = 0;

            Console.WriteLine("Welcome " + Name + ". Do you want to do the COIN FLIP CHALLENGE? Yes / No.");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "no")
            {
                //No
                Console.WriteLine("You are a coward " + Name + " !");
            }
            else
                for (int i = 0; i < 5; i++)
                {
                    //Yes
                    Console.WriteLine("heads or tails?");
                    string guess = Console.ReadLine();

                    Random ran = new Random();
                    int randNum = ran.Next(0, 2);

                    if (randNum == 1 && guess == "heads")
                    {
                        Console.WriteLine("The coin flip was heads correct!");
                        score++;
                    }
                    else if (randNum == 0 && guess == "tails")
                    {
                        Console.WriteLine("The coin flip was tails correct!");
                        score++;
                    }
                    else if (randNum == 1 && guess == "tails")
                    {
                        Console.WriteLine("wrong!");
                    }
                    else if (randNum == 0 && guess == "heads")
                    {
                        Console.WriteLine("wrong!");
                    }
                }
            Console.WriteLine("Thank you " + Name + ". You got a score of " + score + ".");
        }
    }
}

