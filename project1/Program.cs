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

            //Declarations
            List<Player> chosenPlayers;
            List<Player> playerList;
            List<Player> costEffectiveList;
            ConsoleKey sentinelValue = ConsoleKey.Enter;
            ConsoleKey userInput;
            double budget = 95000000;
            //double draftMoney = 95000000;


            //Instructions
            Console.WriteLine("Welcome to the NFL Draft!");


            Console.WriteLine("To begin the draft press any key");
            Console.WriteLine("To exit the draft press enter");

            //Get user input to begin draft
            userInput = Console.ReadKey().Key;
            Console.WriteLine(); //Strictly for formatting purposes
            
            //Continue program unless they escape
            while (userInput != sentinelValue)
            {
                Console.Clear();
                Console.WriteLine("You may pick any combination of players\n");
                Console.WriteLine("\tHere are the Rules:");
                Console.WriteLine("\t1. The total combined salary of all players cannot exceed your $95 million budget");
                Console.WriteLine("\t2. You may pick up to 5 players");
                Console.WriteLine("\t3. If all 5 of your players are within the top 3 AND their combined salaries are $65 mil or less,");
                Console.WriteLine("\t   you will receive a special alert that your draft is Cost Effective!\n");

                // List to hold chosen players                
                chosenPlayers = new List<Player>();
                // List to hold cost effective players (playes in 1st, 2nd, or 3rd best)
                costEffectiveList = new List<Player>();
                // List to hold all player objects
                playerList = new List<Player>()


                {
                    new Player("Joe Burrow", "LSU","Quarterback", 26400100, true, "the best"),
                    new Player("Tua Tagovailoa", "Alabama", "Quarterback", 20300100, true,"the 2nd best"),
                    new Player("Justin Herbet", "Oregon", "Quarterback", 17420300, true, "the 4th best" )
                };

                //Output the list of players
                playerList.ForEach(i => Console.WriteLine(i.ToString()));


                //User input for position.
                Console.WriteLine("\nPlease enter the position you wish to draft from: \n1. Quarterback\n2. Running Back\n3. Wide Receiver"); // Or enter 0 to end draft
                int positionNumber = Convert.ToInt32(Console.ReadLine()); //primer

                //// This while statement is what makes the program loop around starting from this point forward
                while (positionNumber != 0 && chosenPlayers.Count < 5)
                {

                    string position = "";
                    //Exception Handling
                    //while (positionNumber != 1 & positionNumber != 2 & positionNumber !=3 & positionNumber !=4 & positionNumber !=5)
                    //{
                        if (positionNumber == 1)
                        {
                            position = "Quarterback";
                           
                        }
                        else if (positionNumber == 2)
                        {
                            position = "Running Back";
                            

                        }
                        else if (positionNumber == 3)
                        {
                            position = "Wide Receiver";
                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid Selection");
                        }

                    //}//end of while loop

                    string userRanking = "";

                    Console.WriteLine("\nPlease enter ranking: \n1. The Best\n2. 2nd Best\n3. 3rd Best\n4. 4th Best\n5. 5th best");
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

                    else if (rankingNumber == 4)
                    {
                        userRanking = "the 4th best";
                    }

                    else if (rankingNumber == 5)
                    {
                        userRanking = "the 5th best";
                    }

                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }
                    Console.Clear();
                    //While loop go here?? but what for??


                        //Logic to determine who user picked
                        for (var i = playerList.Count - 1; i >= 0; i--)
                            if (playerList[i].Position.Contains(position) && playerList[i].Rank == userRanking)
                            {
                                budget = budget - playerList[i].Salary;

                            if (playerList[i].Availability == true)
                                {
                                    playerList[i].Availability = false;
                                    Console.WriteLine("\nGood pick! This is the player you have chosen:"); 
                                    Console.WriteLine(playerList[i].ToString());
                                    Console.WriteLine("\nYour remaining budget is: " + budget.ToString("c"));
                                    chosenPlayers.Add(playerList[i]);
                                    //playerList.RemoveAt(i);
                                    

                                    if (budget <= 0)
                                        {
                                            Console.WriteLine("Oops! You have exceeded your budget! Please select a less expensive Player.");
                                        }

                                }


                                else
                                {
                                    Console.WriteLine("You have already chosen this player. Please choose another Player");
                                }

                            }

                    
                    Console.WriteLine("");
                    

                    //output all players still remaining
                    Console.WriteLine("These are the players that are availabe to select:");
                    playerList.ForEach(i => {
                        if (i.Availability == false) {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(i.ToString());
                            Console.ResetColor();

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(i.ToString());
                            Console.ResetColor();
                        }

                        });

                    //User input for position.
                    Console.WriteLine("\nPlease enter the position you wish to draft from: \n1. Quarterback\n2. Running Back\n3. Wide Receiver\nOr enter 0 to end draft");
                    positionNumber = Convert.ToInt32(Console.ReadLine()); //Primer
                    //Clear Console of previous data for usability 
                    //Console.Clear();
                }//End of player selection loop


                ////Cost Effective Logic\\\\ 
                //for (var i = 0; i <= chosenPlayers.Count; i++)
                //{
                //    if (chosenPlayers[i].Rank == "the best" || chosenPlayers[i].Rank == "the 2nd best" || chosenPlayers[i].Rank == "the 3rd best")
                //    {
                //       //Need the Salary value and logic to include if the salary is less than 65 million (should it go
                //       // in the above if statement? can i have multiple ORs and ANDs or should it be an extra If statement?)
                //        costEffectiveList.Add(chosenPlayers[i]);
                //    }
                //}

                //Testing//
                //costEffectiveList.ForEach(i => Console.WriteLine(i.ToString()));

                //Formatting so it is easier to read 
                Console.WriteLine("");

                //Show players who have been selected
                Console.WriteLine("\nThese are the players you have selected");
                chosenPlayers.ForEach(i => Console.WriteLine(i.ToString()));

                    Console.WriteLine("\n\nTo start a new draft press any key");
                    Console.WriteLine("To finish the draft and exit the program, press enter.");

                //Get user input from keyboard to start draft over or exit program 
                userInput = Console.ReadKey().Key;
                chosenPlayers.Clear();
                playerList.Clear();
                costEffectiveList.Clear();

            }// End of outer While loop

            
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


            return String.Format(Position + " | " + Name + " | " + Institution + " | " + Salary.ToString("c") + " | " + Rank);
           
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
