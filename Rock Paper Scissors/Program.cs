namespace Rock_Paper_Scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Rock Paper Scissors.");
            Random random = new Random();
            int playerscore = 0;
            int enemyscore = 0;
            do
            {
                Console.WriteLine("What would you like to pick? ROCK PAPER or SCISSORS?");
                String choice = Console.ReadLine();
                int botchoice = random.Next(0, 3); //we start at zero, the upper bound is exclusive so you go one higher
                if (choice == "ROCK")
                {
                    Console.WriteLine("You have chosen ROCK!");
                  
                    switch (botchoice)
                    {
                        case 0:
                            Console.WriteLine("Tie!");
                            break;
                        case 1:
                            Console.WriteLine("You lose, paper beats rock!");
                            enemyscore++;
                            break;
                        case 2:
                            Console.WriteLine("You win, rock beats scissors!");
                            playerscore++;
                            break;
                    }
                }
                if (choice == "PAPER")
                {
                    Console.WriteLine("You have chosen PAPER!"); 
                  
                    switch (botchoice)
                    {
                        case 0:
                            Console.WriteLine("You win, paper beats rock!");
                            playerscore++;
                            break;
                        case 1:
                            Console.WriteLine("Tie!");
                            break;
                        case 2:
                            Console.WriteLine("You lose, scissors beat paper!");
                            enemyscore++;
                            break;
                    }
                }
                if (choice == "SCISSORS")
                {
                    Console.WriteLine("You have chosen SCISSORS!");
                    switch (botchoice)
                    {
                        case 0:
                            Console.WriteLine("You lose, rock beats scissors!");
                            enemyscore++;
                            break;
                        case 1:
                            Console.WriteLine("You win, scissors beat paper!");
                            playerscore++;
                            break;
                        case 2:
                            Console.WriteLine("Tie!");
                            break;
                    }
                    //scissors = true;
                }
                
               
            } while (playerscore < 3 && enemyscore < 3);

            if (playerscore == 3)
            {
                Console.WriteLine("You won!");
            }
            if (enemyscore == 3) 
            {
                Console.WriteLine("Computer wins!");
            }
        }
    }
}
