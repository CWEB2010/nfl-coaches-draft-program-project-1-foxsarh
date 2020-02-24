﻿/*
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

            /*string[,] nameArray = { //populating data in the player object
                                        {"Joe Burrow", "Tua Tagovailoa", 17420300, 13100145, 10300000},
                                        {24500100, 19890200 , 18700800, 15000000, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5}
                                   };

            string [,] institutionArray = { //populating data in the player object
                                            {26400100, 20300100, 17420300, 13100145, 10300000},
                                            {24500100, 19890200 , 18700800, 15000000, 5},
                                            {1, 2 ,3 , 4, 5},
                                            {1, 2 ,3 , 4, 5},
                                            {1, 2 ,3 , 4, 5},
                                            {1, 2 ,3 , 4, 5},
                                            {1, 2 ,3 , 4, 5},
                                            {1, 2 ,3 , 4, 5}
                                          };

            string[,] positionAray = { //populating data in the player object
                                        {"Quarterback", "Quarterback", "Quarterback", "Quarterback", "Quarterback"},
                                        {"Running back", "Running back", "Running back", "Running back", "Running back"},
                                        {"Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver"},
                                        {"Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman"},
                                        {"Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back", "Defensive-Back"},
                                        {"Tight Ends", "Tight Ends", "Tight Ends", "Tight Ends", "Tight Ends"},
                                        {"Line-Backer's", "Line-Backer's", "Line-Backer's", "Line-Backer's", "Line-Backer's"},
                                        {"Offensive Tackles", "Offensive Tackles", "Offensive Tackles", "Offensive Tackles", "Offensive Tackles"}
                                     };

            double[,] salaryArray = { //populating data in the player object
                                        {26400100, 20300100, 17420300, 13100145, 10300000},
                                        {24500100, 19890200 , 18700800, 15000000, 11600400},
                                        {23400000, 21900300, 19300230, 13400230, 10000000},
                                        {26200300, 22000000, 16000000, 18000000, 13000000},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5},
                                        {1, 2 ,3 , 4, 5}
                                    };


            string[,] rankArray = { 
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                                    {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"}
                                  }; */
            //string[,] rosterArray =
            //{
            //    {"Joe Burrow", "LSU","Quarterback", "26400100","the best" },
            //    {"Tua Tagovailoa", "Alabama", "Quarterback", "20300100","the 2nd best" },
            //    {"Justin Herbet", "Oregon", "Quarterback", "17420300", "the 4th best" },
            //    {"Jordan Love","Utah St", "Quarterback", "13100145","the 5th best"}

            //};

            Console.WriteLine("Welcome to the NFL Draft!");
            Console.WriteLine("You may pick any combination of players");
            Console.WriteLine("Here are the Rules:");
            Console.WriteLine("\t1. The total combined salary of all players cannot exceed your $95 million budget");
            Console.WriteLine("\t2. You may pick up to 5 players");
            Console.WriteLine("\t3. If all 5 of your players are within the top 3 --and--");
            Console.WriteLine("\t\ttheir combined salaries are $65 mil or less,");
            Console.WriteLine("\t\tyou will receive a special alert that your draft is Cost Effective!");

            // Create new list to hold only player objects 
            List<Player> playerList = new List<Player>()
            {
                new Player("Joe Burrow", "LSU","Quarterback", 26400100, true, "the best"),
                new Player("Tua Tagovailoa", "Alabama", "Quarterback", 20300100, true,"the 2nd best"),
                new Player("Justin Herbet", "Oregon", "Quarterback", 17420300, true, "the 4th best" )
            };
            List<Player> chosenPlayers = new List<Player>();

            //Output the list
            foreach (Player aPlayer in playerList)
            {
                Console.WriteLine(aPlayer.Name, aPlayer.Institution, aPlayer.Salary, aPlayer.Rank);
            }

            string position = "";

            //User input for position.
            Console.WriteLine("Please enter position: \n 1.Quarterback\n2.Running Back\n3. Wide Receiver\n");
            int positionNumber = Convert.ToInt32(Console.ReadLine());

            if( positionNumber == 1)
            {
                position = "Quarterback";
            }
            else if(positionNumber == 2)
            {
                position = "Running Back";

            }else if(positionNumber == 3)
            {
                position = "Wide Receiver";
            }
            else
            {
                Console.WriteLine("Invalid Selection");
            }

            //Console.WriteLine("Please enter Rank: \n 1.The Best \n2.The Second Best \n3. The third Best\n");
            //selection 
            string selection = "the best";

            Player selectedPlayer;
            //Determine users pick
            /**foreach (Player aPlayer in playerList)
            {
               if((aPlayer.Position == position)  && (aPlayer.Rank == selection))
                {
                    chosenPlayers.Add(aPlayer);

                   
                   
                }
               
            }**/

            for (var i = playerList.Count - 1; i >= 0; i--)
            {
                if (playerList[i].Position.Contains(position) && playerList[i].Rank == selection)
                {
                    chosenPlayers.Add(playerList[i]);
                    playerList.RemoveAt(i);
                }
            }





            Console.Clear();
            //output all players still remaining
            Console.WriteLine("These are the players that are availabe to select:");
            foreach (Player aPlayer in playerList)
            {
                Console.WriteLine(aPlayer.Name, aPlayer.Institution, aPlayer.Salary, aPlayer.Rank);
            }

            //Show players who have been selected
            Console.WriteLine("These are the players you have selected");
            foreach (Player aPlayer in chosenPlayers)
            {
                Console.WriteLine(aPlayer.Name, aPlayer.Institution, aPlayer.Salary, aPlayer.Rank);
            }


            /*string[] names = { "Joe Burrow", "Tua Tagovailoa" };
            string[] institutions = { "LSU", "Alabama", "Oregon" };
            string[] positions = {"Quarterback","Running Back","Wide-Receiver" };
            double[] salaries = {26400100, 20300100, 17420300 };
            string[] ranks = { "The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"};
            */

            // Use a loop to assign all player data to player objects 
            //for (var r = 0; r <=4; r++) // Outter loop (r stands for Row)
            //{
            //    for (var c = 0; c <=4; c++) // Inner loop (c stands for Column)
            //    {
            //        Player name = new Player(nameArray[r, c], institutionArray[r, c], positionAray [r, c], salaryArray[r, c],true, rankArray[r,c]);
            //        Player name = new Player(rosterArray[r, c], rosterArray[r, c], rosterArray[r, c], Convert.ToDouble(rosterArray[r, c]), true, rosterArray[r, c]);
            //        playerList.Add(name);
            //    } // End of Inner Loop

            //} // End of Outter Loop

            /*foreach (Player aPlayer in playerList)
            {
                Console.WriteLine(aPlayer.Name, aPlayer.Institution, aPlayer.Salary, aPlayer.Rank);
            }*/

            // Create Welcome Message and Instructions \\
            //Console.WriteLine("Welcome to the NFL Draft!");
            //Console.WriteLine("You may pick any combination of players");
            //Console.WriteLine("Here are the Rules:");
            //Console.WriteLine("\t1. The total combined salary of all players cannot exceed your $95 million budget");
            //Console.WriteLine("\t2. You may pick up to 5 players");
            //Console.WriteLine("\t3. If all 5 of your players are within the top 3 --and--");
            //Console.WriteLine("\t\ttheir combined salaries are $65 mil or less,");
            //Console.WriteLine("\t\tyou will receive a special alert that your draft is Cost Effective!");

            //User input for position.
            Console.WriteLine("1.Quarterback\n2.Running Back\n3. Wide Receiver\n");
            
            // the loop should be the length of the arrays 
            // Loop should be 0-24 (25 long) 
            /*Player aPlayer = new Player ( "Ben", "Inst", "Pos", 12, true, "best");*/
        }
    } // End of Program
    class Player
    {
        public string Name;
        public string Institution;
        public string Position { get; set; }
        public double Salary;
        public bool Availability;
        public string Rank;

        public Player(string Name, string Inst, string Pos, double Salary, bool Avail, string Rank)
        {
            this.Name = Name;
            this.Institution = Inst;
            Position = Pos;
            this.Salary = Salary;
            Availability = Avail;
            this.Rank = Rank;
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
