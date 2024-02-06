using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciccor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int ComputerScore = 0;
            int PlayerScore = 0;
            Console.WriteLine("Rock Paper Sciccor Game!!!");

            while (ComputerScore != 3 && PlayerScore != 3)
            {

                Console.WriteLine("Compute Score : " + ComputerScore + "Player Score : " + PlayerScore);
                Console.WriteLine("Type r for Rock , p for Paper or s for sciccor !!");
                Console.WriteLine("Please press any key to exit!!!");
                int Computerchoice = random.Next(0, 3);
                string Playerchoice = Console.ReadLine();

                if (Computerchoice == 0)
                {
                    //Computer Choose Rock 
                    switch (Playerchoice)

                    {
                        case "r":
                            Console.WriteLine("It's a Tie!!");
                            Console.WriteLine("Computer also choose Rock..");
                            break;

                        case "p":
                            Console.WriteLine("You got one point!!");
                            Console.WriteLine("Computer choose Rock..");
                            PlayerScore++;
                            break;
                        case "s":
                            Console.WriteLine("Sorry you lost your point!!");
                            Console.WriteLine("Computer choose Rock..");
                            ComputerScore++;
                            break;

                        default: break;
                    }

                }

                else if (Computerchoice == 1)
                {
                    //Computer Choose Paper 
                    switch (Playerchoice)
                    {
                        case "r":
                            Console.WriteLine("Sorry you lost your point!!");
                            Console.WriteLine("Computer choose Paper..");
                            ComputerScore++; break;

                        case "p":
                            Console.WriteLine("It's a Tie!!");
                            Console.WriteLine("Computer also choose Paper..");
                            break;

                        case "s":
                            Console.WriteLine("You got one point!!");
                            Console.WriteLine("Computer choose Paper..");
                            PlayerScore++;
                            break;

                        default: break;
                    }

                }
                else
                {
                    //Computer Choose Sciccor
                    switch (Playerchoice)
                    {
                        case "r":
                            Console.WriteLine("You got one point!!");
                            Console.WriteLine("Computer choose Sciccor..");
                            PlayerScore++;
                            break;

                        case "p":
                            Console.WriteLine("Sorry you lost your point!!");
                            Console.WriteLine("Computer choose Sciccor..");
                            ComputerScore++; break;

                        case "s":
                            Console.WriteLine("It's a Tie!!");
                            Console.WriteLine("Computer also choose Sciccor..");
                            break;

                        default:
                            break;
                    }
                    }
                
            }
         

            if (PlayerScore == 3)
            {
                Console.WriteLine("Congratulations!You won the game!!!");
            }
            else
            {
                Console.WriteLine("Sorry!You lost this time.Better luck next time!");
            }
            Console.ReadLine();

        }
    }
}
