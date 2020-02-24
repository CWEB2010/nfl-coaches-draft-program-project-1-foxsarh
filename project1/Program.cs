/*
 * Create a list with all of the player //clear the list then generate the list
 * Print introduction for user
 * WHILE (Console.Key != Console.Key X)
 *    OutputList()
 * While budget < 95 million && count < 5  && coachPick != x
 *     Get input from user to select a player position from list by entering a # between 1-8
     * If user inputs number x
     *      Display available players with info from x position 
     *      Get input from user for which player they want to pick
     *     ?? While user input is Yes?? <--- where does this while loop go ??????
     *      If user selects x player
     *          Subtract the player's salary from $95 mil
     *          Subtract the player's salary from $65 mil in a costEffective variable
     *          Display the player's info to console so user can see
     *          Is the player best, second best or 3rd best?
     *          Ask if user would like to select another player (Y/N)
     *          If user selects Yes and budget is under 95 million
     *              Display available players
     *              Get user input to pick player
     *              Subtract player salary from 95 million .. 
     *              Is the player best, second best or 3rd best? ... 
     *                  If the salary is bigger than remaining budget
     *                      Print error message that they must select a different player
     *                      Display available players ....
     *          If user selects Yes and budget is 84 mil or over
     *              Print "You have exceeded your budget and do not have enough $ left to pick a player"
     *              Display all draft picks 
     *          If user selects no and budget is under 65 million and all players are within first 3 bests
     *              Print message that states "Cost Effective"
     *          If user selects no and budget is over 65 million
     *              Display all draft picks        
 */

using System;
using System.Collections.Generic;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the NFL Draft!");
            Console.WriteLine("You may pick any combination of players");
            Console.WriteLine("Here are the Rules:");
            Console.WriteLine("\t1. The total combined salary of all players cannot exceed your $95 million budget");
            Console.WriteLine("\t2. You may pick up to 5 players");
            Console.WriteLine("\t3. If all 5 of your players are within the top 3 --and--");
            Console.WriteLine("\t   their combined salaries are $65 mil or less,");
            Console.WriteLine("\t   you will receive a special alert that your draft is Cost Effective!");

            //Declarations

            ////List Declarations
            List<Player> chosenPlayers = new List<Player>();

            // Create new list to hold only player objects 
            List<Player> playerList = new List<Player>()


            {
                new Player("Joe Burrow", "LSU","Quarterback", 26400100, true, "the best"),
                new Player("Tua Tagovailoa", "Alabama", "Quarterback", 20300100, true,"the 2nd best"),
                new Player("Justin Herbet", "Oregon", "Quarterback", 17420300, true, "the 4th best" )
            };


            //Output the list
            foreach (Player aPlayer in playerList)
            {
                Console.WriteLine(aPlayer.Name, aPlayer.Institution, aPlayer.Position, aPlayer.Salary, aPlayer.Rank);
            }

            string position = "";

            //User input for position.
            Console.WriteLine("Please enter position: \n1. Quarterback\n2. Running Back\n3. Wide Receiver\n");
            int positionNumber = Convert.ToInt32(Console.ReadLine());

            //Exception Handling
            while (positionNumber == 1 || positionNumber == 2 || positionNumber == 3 || positionNumber == 4 || positionNumber == 5)
            {
                if (positionNumber == 1)
                {
                    position = "Quarterback";
                    break;
                }
                else if (positionNumber == 2)
                {
                    position = "Running Back";
                    break;

                }
                else if (positionNumber == 3)
                {
                    position = "Wide Receiver";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Selection, please try again & enter a number between 1 and 5");
                }

            } // end while loop

            string userRanking = "";

            Console.WriteLine("Please enter ranking: \n1. The Best\n2. 2nd Best\n3. 3rd Best\n4. 4th Best\n5. 5th best"); 
            int rankingNumber = Convert.ToInt32(Console.ReadLine());

            if (rankingNumber == 1)
            {
                userRanking = "the best";
            }
            else if (rankingNumber == 2)
            {
                userRanking = "the 2nd best";

            }
            else if (rankingNumber == 3)
            {
                userRanking = "the 3rd best";
            }

            else if(rankingNumber == 4)
            {
                userRanking = "the 4th best";
            }

            else if(rankingNumber == 5)
            {
                userRanking = "the 5th best";
            }

            else
            {
                Console.WriteLine("Invalid Selection");
            }

            //Player selectedPlayer;
            //Determine users pick
            /*foreach (Player aPlayer in playerList)
            {
               if((aPlayer.Position == position)  && (aPlayer.Rank == selection))
                {
                    chosenPlayers.Add(aPlayer);
                    //chosenPlayers.Remove(playerList);
                   
                   
                }
               
            }**/

            for (var i = playerList.Count - 1; i >= 0; i--)
                if (playerList[i].Position.Contains(position) && playerList[i].Rank == userRanking)
                {
                    chosenPlayers.Add(playerList[i]);
                    playerList.RemoveAt(i);
                    
                }




            //Clear Console of previous data for usability 
            Console.Clear();
            //output all players still remaining
            Console.WriteLine("These are the players that are availabe to select:");
            playerList.ForEach(x => Console.WriteLine(x.ToString()));

            foreach (Player aPlayer in playerList)
            {
                Console.WriteLine(aPlayer.Name, aPlayer.Institution, aPlayer.Salary, aPlayer.Rank);
            }

            //Formatting so it is easier to read 
            Console.WriteLine();

            //Show players who have been selected
            Console.WriteLine("These are the players you have selected");
            foreach (Player aPlayer in chosenPlayers)
            {
                Console.WriteLine(aPlayer.Name + aPlayer.Institution, aPlayer.Salary, aPlayer.Rank);
            }



            //Reprint instructional menu for user 
            //User input for position.
            Console.WriteLine("\n1. Quarterback\n2. Running Back\n3. Wide Receiver\n");



            // the loop should be the length of the arrays 
            // Loop should be 0-24 (25 long) 
            /*Player aPlayer = new Player ( "Ben", "Inst", "Pos", 12, true, "best");*/
        }
    } // End of Program
    class Player
    {
        public string Name;
        public string Institution { get; set; }
        public string Position { get; set; }
        public double Salary;
        public bool Availability;
        public string Rank;

        public Player(string Name, string Institution, string Position, double Salary, bool Availability, string Rank)
        {
            this.Name = Name;
            this.Institution = Institution;
            this.Position = Position;
            this.Salary = Salary;
            this.Availability = Availability;
            this.Rank = Rank;
        }

        public override string ToString()
        {
            return String.Format(Position + " | " + Name + " | " + Institution + " | "  +  Salary.ToString("c") + " | " + Rank);
        }

        public void determineBest (int count)
        {
            // Logic to determine The best, 1st best, 2nd best... etc
            if (count == 1)
            {
                Rank = "The Best";
            }

            else if (count == 2)
            {
                Rank = "2nd Best";
            }

            else if (count == 3)
            {
                Rank = "3rd Best";
            }

            else if (count == 4)
            {
                Rank = "4th Best";
            }

            else if (count == 5)
            {
                Rank = "5th Best";
            }

        }
    } // End of player class 
}// End of namespace
