using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //Creates a variable that contains a random number

            for (int i = 0; i < 5; i++){

                int hand1 = rnd.Next(1, 4);
                
                int hand2 = rnd.Next(1, 4);

                string Player1 = "";

                string Player2 = "";

                if (hand1 == 1)
                { 
                    Player1 = "Scissors";
                    Console.WriteLine(Player1);
                }

                else if (hand1 == 2)
                {
                    Player1 = "Paper";
                    Console.WriteLine(Player1);
                }

                else if (hand1 == 3)
                {
                    Player1 = "Rock";
                    Console.WriteLine(Player1);
                }

                if (hand2 == 1)
                {
                    Player2 = "Scissors";
                    Console.WriteLine(Player2);
                }

                else if (hand2 == 2)
                {
                    Player2 = "Paper";
                    Console.WriteLine(Player2);
                }

                else if (hand2 == 3)
                {
                    Player2 = "Rock";
                    Console.WriteLine(Player2);
                }

                if (Player1 == "Scissors")
                {

                    if (Player2 == "Scissors")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, no one wins", Player1, Player2);
                    }

                    else if (Player2 == "Paper")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, Player 1 wins", Player1, Player2);
                    }

                    else if (Player2 == "Rock")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, Player 2 wins", Player1, Player2);
                    }

                }

                if (Player1 == "Rock")
                {

                    if (Player2 == "Rock")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, no one wins", Player1, Player2);
                    }

                    else if (Player2 == "Scissors")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, Player 1 wins", Player1, Player2);
                    }

                    else if (Player2 == "Paper")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, Player 2 wins", Player1, Player2);
                    }

                }

                if (Player1 == "Paper")
                {

                    if (Player2 == "Paper")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, no one wins", Player1, Player2);
                    }

                    else if (Player2 == "Rock")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, Player 1 wins", Player1, Player2);
                    }

                    else if (Player2 == "Scissors")
                    {
                        Console.WriteLine("Player 1 - {0}, Player 2 - {1}, Player 2 wins", Player1, Player2);
                    }

                }


                Console.ReadLine();
            }

        }
    }
}
