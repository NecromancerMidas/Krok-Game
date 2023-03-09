// See https://aka.ms/new-console-template for more information




using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Krokgame
{
    class Program
        
    
{
        

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am the krokodile Game what's your name?");
            
          string name = Console.ReadLine();
            Console.WriteLine("Welcome: " + name + " Let's play!");
            Game(name, 0);
           


        }
        static void Game(string name, int score)
        

        {
            Random rnd = new Random();
            int score1 = 0;
            if (score != 0) {
                score1 = score;                
            }
            else
            {
                score1 = 0;
            }

            Console.WriteLine("Current score is " + score);
            int left = rnd.Next(0,100);
            int right = rnd.Next(0,100);
            Console.Write(left);
            Console.WriteLine(" ? " + right);
            string answer = Console.ReadLine();
            if (left < right)
            {
                if (answer == "<")
                {
                    score1++;
                    Console.WriteLine("Well done " + name + "! You answered correctly");
                }
                else
                {
                    Console.WriteLine("Not quite right :( " + name + ". Try again");
                }
            }
           else if (left > right)
            {
                if (answer == ">")
                {
                    score1++;
                    Console.WriteLine("Well done " + name + "! You answered correctly");
                }
                else
                {
                    Console.WriteLine("Not quite right :( " + name + ". Try again");
                }
            }
          else if (left == right)
            {
                if (answer == "=")
                {
                    score1++;
                    Console.WriteLine("Well done " + name + "! You answered correctly");
                }
                else
                {
                    Console.WriteLine("Not quite right :( " + name + ". Try again");
                }
            }

            Console.WriteLine("Let's go again!");
            Game(name, score1);
        
        }

    }
}

