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
            long budget = 95000000;
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
                    new Player("Joe Burrow", "LSU","Quarterback", 26400100, true, "The Best"),
                    new Player("Tua Tagovailoa", "Alabama", "Quarterback", 20300100, true,"The 2nd Best"),
                    new Player("Justin Herbet", "Oregon", "Quarterback", 17420300, true, "The 3rd Best" ),
                    new Player("Jordan Love","Utah St","Quarterback", 13100145, true, "The 4th Best"),
                    new Player("Jake Fromm","Georgia","Quarterback", 10300000, true, "The 5th Best" ),
                    new Player("D,Andre Swift","Georgia","Running Back", 24500100, true, "The Best"),
                    new Player("Jonathan Taylor","Wiscosnsin","Running Back", 19890200, true, "The 2nd Best" ),
                    new Player("J.K. Dobbins","Ohio St","Running Back", 18700800, true,"The 3rd Best" ),
                    new Player("Zack Moss","Utah","Running Back", 15000000, true, "The 4th Best" ),
                    new Player("Cam Akers","Florida St","Running Back", 11600400, true, "The 5th Best" ),
                    new Player("CeeDee Lamb","Oklahoma","Wide Receiver", 23400000, true, "The Best" ),
                    new Player("Jerry Jeudy","Alabama","Wide Receiver", 21900300, true, "The 2nd Best" ),
                    new Player("Tee Higgins","Clemson","Wide Receiver", 19300230, true, "The 3rd Best" ),
                    new Player("Henry Rugs III","Alabama","Wide Receiver", 13400230, true, "The 4th Best" ),
                    new Player("Tyler Johnson","Minnesota","Wide Receiver", 10000000, true, "The 5th Best" ),
                    new Player("Chase Young","Ohio St","Defensive Lineman", 26200300, true, "The Best" ),
                    new Player("Derrick Brown","Auburn","Defensive Lineman", 22000000, true, "The 2nd Best" ),
                    new Player("A.J. Epenesa","Iowa","Defensive Lineman", 16000000, true, "The 3rd Best" ),
                    new Player("Javon Kinlaw","So. Carolina","Defensive Lineman", 18000000, true, "The 4th Best" ),
                    new Player("Yetur Gross-Matos","Penn St","Defensive Lineman", 13000000, true, "The 5th Best" ),
                    new Player("Jeff Pkudah","Ohio St","Defensive-Back", 24000000, true, "The Best" ),
                    new Player("Grant Delpit","LSU","Defensive-Back", 22500249, true, "The 2nd Best" ),
                    new Player("Kristian Fulton","LSU","Defensive-Back", 20000100, true, "The 3rd Best" ),
                    new Player("Xavier McKinney","Alabama","Defensive-Back", 16000200, true, "The 4th Best" ),
                    new Player("CJ Henderson","Florida","Defensive-Back", 11899999, true, "The 5th Best" ),
                    new Player("Cole Kmet","Notre Dame","Tight Ends", 27800900, true, "The Best" ),
                    new Player("Brycen Hopkins","Purdue","Tight Ends", 21000800, true, "The 2nd Best" ),
                    new Player("Hunter Bryant","Washington","Tight Ends", 17499233, true, "The 3rd Best" ),
                    new Player("Jared Pinkney","Vanderbilt","Tight Ends", 27900200, true, "The 4th Best" ),
                    new Player("Jacob Breeland","Oregon","Tight Ends", 14900333, true, "The 5th Best" ),
                    new Player("Isaiah Simmons","Clemson","Line-Backers", 22900300, true, "The Best" ),
                    new Player("Kenneth Murray","Oklahoma","Line-Backers", 1900590, true, "The 2nd Best" ),
                    new Player("Zack Baun","Wisconsin","Line-Backers", 18000222, true, "The 3rd Best" ),
                    new Player("Akeem Davis-Gaither","App St","Line-Backers", 12999999, true, "The 4th Best" ),
                    new Player("Troy Dye","Oregon","Line-Backers", 10000100, true, "The 5th Best" ),
                    new Player("Jedrick Wills Jr","Alabama","Offensive Tackles", 23000000, true, "The Best" ),
                    new Player("Andrew Thomas","Georgia","Offensive Tackles", 20000000, true, "The 2nd Best" ),
                    new Player("Tristan Wirfs","Iowa","Offensive Tackles", 19400000, true, "The 3rd Best" ),
                    new Player("Tyler Biadasz","Wisconsin","Offensive Tackles", 16200700, true, "The 4th Best" ),
                    new Player("Mekhi Becton","Louisville","Offensive Tackles", 15900000, true, "The 5th Best" )
                };

                //Output the list of players
                playerList.ForEach(i => Console.WriteLine(i.ToString()));


                //User input for position.
                Console.WriteLine("\nPlease enter the position you wish to draft from: \n1. Quarterback\n2. Running Back\n3. Wide Receiver\n4. Defensive Lineman" +
                    "\n5. Defensive-Back\n6. Tight Ends\n7. "); // Or enter 0 to end draft
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

                        else if (positionNumber == 4)
                        {
                            position = "Defensive Lineman";
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
                        userRanking = "The Best";
                    }
                    else if (rankingNumber == 2)
                    {
                        userRanking = "The 2nd Best";

                    }
                    else if (rankingNumber == 3)
                    {
                        userRanking = "The 3rd Best";
                    }

                    else if (rankingNumber == 4)
                    {
                        userRanking = "The 4th Best";
                    }

                    else if (rankingNumber == 5)
                    {
                        userRanking = "The 5th Best";
                    }

                    else
                    {
                        Console.WriteLine("Invalid Selection");
                    }


                    Console.Clear();

                    //Logic to determine who user picked
                    for (var i = playerList.Count - 1; i >= 0; i--)
                    {
                        if (playerList[i].Position.Contains(position) && playerList[i].Rank == userRanking)
                        {  

                            if (playerList[i].Availability == true)
                            {
                                budget = budget - playerList[i].Salary;
                                long remainingBudget = 95000000 - budget;

                                if (budget >= 0)
                                {
                                    playerList[i].Availability = false;
                                    Console.WriteLine("\nThis is the player you have selected:");
                                    Console.WriteLine(playerList[i].ToString());

                                    chosenPlayers.Add(playerList[i]);
                                    //playerList.RemoveAt(i);
                                    Console.WriteLine("\nYour remaining budget is: " + budget.ToString("c"));
                                    Console.WriteLine("You have spent " + remainingBudget.ToString("C") + " of your total budget");

                                    //Cost effective logic 
                                    //for (var x = chosenPlayers.Count - 1; x <= 0; x--)
                                    //{
                                    //    if (chosenPlayers[x].Rank == "the best" || chosenPlayers[x].Rank == "the 2nd best" || chosenPlayers[x].Rank == "the 3rd best")
                                    //    {
                                            //Need the Salary value and logic to include if the salary is less than 65 million (should it go
                                            // in the above if statement? can i have multiple ORs and ANDs or should it be an extra If statement?)

                                            //if (remainingBudget <= 65000000)
                                            //{
                                            //    costEffectiveList.Add(chosenPlayers[i]);
                                            //    Console.WriteLine("Well done, your choices are cost effective!");

                                            //}
                                    //    }
                                    //}

                                }

                                else
                                {
                                    Console.WriteLine("You have exceeded your budget! Please select a less expensive player.");
                                    Console.WriteLine();
                                    //Adjusting the math so that it does not subtract the salary if they're not added to list 
                                    budget = budget + playerList[i].Salary;

                                }

                            }

                            else
                            {
                                Console.WriteLine("You have already chosen this player. Please choose another Player");
                            }


                        }
                    }

                    //else
                    //{

                    //    Console.WriteLine("You have exceeded your budget! Please select a less expensive player.");
                    //    Console.WriteLine();

                    //}
                    
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


                //Cost Effective Logic\\
                //for (var i = chosenPlayers.Count -1; i <= 0; i--)
                //{
                //    if (chosenPlayers[i].Rank == "the best" || chosenPlayers[i].Rank == "the 2nd best" || chosenPlayers[i].Rank == "the 3rd best")
                //    {
                //        //Need the Salary value and logic to include if the salary is less than 65 million (should it go
                //        // in the above if statement? can i have multiple ORs and ANDs or should it be an extra If statement?)
                        
                //        if (budget <= 65000000)
                //        {
                //            costEffectiveList.Add(chosenPlayers[i]);
                //            Console.WriteLine("Well done, your choices are cost effective!");
                //            costEffectiveList.ForEach(x => Console.WriteLine(i.ToString()));
                //        }
                //    }
                //}

                Console.WriteLine("Well done, your choices are cost effective!");
                costEffectiveList.ForEach(i => Console.WriteLine(i.ToString()));

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
        public long Salary;
        public bool Availability;
        public string Rank;

        public Player(string Name, string Institution, string Position, long Salary, bool Availability, string Rank)
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
