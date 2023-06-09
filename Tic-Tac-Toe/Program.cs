/* 
Written By: Dan Jandel C. De Ramos
Polytechnic University of the Philippines Biñan Campus
BSCpE 1-1 2nd Semester
*/

using System;
using System.Text;
using System.Collections.Generic;

namespace Tic_Tac_Toe{

    class Program{        
        
        static List<string> tile = new List<string>();
        static List<int> tileStatus = new List<int>();

        static void initializeLists(){
            
            // Initializing tile values.
            for(int loop = 1; loop <= 9; loop++){
                tile.Add(Convert.ToString(loop));
            }
        
            // Initializing tile status values. Used to check if a tile is filled. 0 = unfilled, 1 = filled.
            for(int loop = 0; loop <= tile.Count-1; loop++){
                tileStatus.Add(0);
            }
        }                        

        static void playerO_WinnerMessage(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game Over. Player O won!");
			Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
			Console.WriteLine("Would you like to play again? 1 = Yes or 0 = No?");
			Console.Write("Enter your choice: ");
        }

        static void playerX_WinnerMessage(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game Over. Player X won!");
			Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
			Console.WriteLine("Would you like to play again? 1 = Yes or 0 = No?");
			Console.Write("Enter your choice: ");
        }

        static void invalidInputMessageForReset(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
			Console.Beep();
			Console.Beep();
            Console.WriteLine("!!! Invalid input. Please choose either 1 for yes and 0 for no only !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void invalidInputMessageForTileInput(){
            Console.ForegroundColor = ConsoleColor.Red;		
			Console.Beep();
			Console.Beep();
            Console.WriteLine("!!! Invalid input. Please choose a number from 1 to 9 only !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void invalidInputMessageForFilledTile(){
            Console.ForegroundColor = ConsoleColor.Red;
			Console.Beep();
			Console.Beep();
            Console.WriteLine("!!! Tile is already filled. Please Choose a different tile !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void resetLists(){

            for(int loop = 0; loop <= tile.Count-1; loop++){
                tile[loop] = Convert.ToString(loop+1);
            }

            for(int loop = 0; loop <= tileStatus.Count-1; loop++){
                tileStatus[loop] = 0;
            }

        }

        static void Main(string[]args){
			
			// Stops the loop when a winning condition or tie has been met
			int gameOver = 0;
            int gameNumber = 1;
			int tieCounter = 0;

            int X_Wins = 0;
            int O_Wins = 0;			
			/*
			Acts as both a turn counter and to determine whether it is player X or O's turn. 
			Turn numbers with even values are turns for player X while turn numbers with odd values are for player O.
			*/
			int turnNumber = 0;

			// Initializing user input
			string userInput = "0";

            initializeLists();                                			          

			Console.Clear();

			while(gameOver == 0){				      

				Console.WriteLine();
                Console.WriteLine("Number of Games: " + gameNumber);
				Console.WriteLine("Turn Number: " + (turnNumber+1));
                Console.WriteLine("Player X Wins: " + X_Wins);
                Console.WriteLine("Player O Wins: " + O_Wins);
				Console.WriteLine("Number of ties: " + tieCounter);
				Console.WriteLine();
				// Turn numbers with even values are turns for player X while turn numbers with odd values are for player O.
				if(turnNumber%2 == 0){
					Console.WriteLine("Player X's Turn");
				}else{
					Console.WriteLine("Player O's Turn");
				}

				Console.WriteLine();
				Console.WriteLine("-------------------");
				
				for(int loop = 0; loop <= 8; loop++){		

					if(loop%3 == 0){						
						Console.Write("|");
					}

					if(tile[loop] == "X"){
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("  " + tile[loop] + "  ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
					}else if(tile[loop] == "O"){
						Console.ForegroundColor = ConsoleColor.Blue;
						Console.Write("  " + tile[loop] + "  ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
					}else{
						Console.Write("  " + tile[loop] + "  ");
						Console.Write("|");
					}

					if(loop != 0 && (loop+1)%3 == 0){
						Console.WriteLine();
						Console.WriteLine("-------------------");
					}					
				}				
				
				/* 
				Winner checker system. 
				Since turnNumber gets an added value per successful turn, when the code loops to check for the winner, the values are inverted
				*/
				
				if(turnNumber%2 == 0){
					if(tile[0] == tile[1] && tile[1] == tile[2]){
						playerO_WinnerMessage();						
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            Console.WriteLine();
                            invalidInputMessageForReset();
                            continue;
                        }	
							
					}

					if(tile[3] == tile[4] && tile[4] == tile[5]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;                            
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
						
					}
					if(tile[6] == tile[7] && tile[7] == tile[8]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;                            
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }	
								
					}
					if(tile[0] == tile[3] && tile[3] == tile[6]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }	
						
					}
					if(tile[1] == tile[4] && tile[4] == tile[7]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
									
					}
					if(tile[2] == tile[5] && tile[5] == tile[8]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
						
					}
					if(tile[0] == tile[4] && tile[4] == tile[8]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;
                            gameOver = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
									
					}
					if(tile[2] == tile[4] && tile[4] == tile[6]){
						playerO_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            O_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }						
					}
					if(
						tileStatus[0] == 1 && 
						tileStatus[1] == 1 && 
						tileStatus[2] == 1 && 
						tileStatus[3] == 1 && 
						tileStatus[4] == 1 &&
						tileStatus[5] == 1 &&  
						tileStatus[6] == 1 &&  
						tileStatus[7] == 1 && 
						tileStatus[8] == 1){
                            Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("Game Over. The game resulted in a tie.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine();
							Console.WriteLine("Would you like to play again? 1 = Yes or 0 = No?");
							Console.Write("Enter your choice: ");
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
							tieCounter++;
                            turnNumber = 0;
                            gameOver = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
					}
				}else{
					if(tile[0] == tile[1] && tile[1] == tile[2]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }	
								
					}
					if(tile[3] == tile[4] && tile[4] == tile[5]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }	
						
					}
					if(tile[6] == tile[7] && tile[7] == tile[8]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
								
					}
					if(tile[0] == tile[3] && tile[3] == tile[6]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
						
					}
					if(tile[1] == tile[4] && tile[4] == tile[7]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
							
					}
					if(tile[2] == tile[5] && tile[5] == tile[8]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }	
						
					}
					if(tile[0] == tile[4] && tile[4] == tile[8]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;

                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }	
								
					}
					if(tile[2] == tile[4] && tile[4] == tile[6]){
						playerX_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            X_Wins++;
                            turnNumber = 0;
                            resetLists();
                            continue;
                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
					}
					if(
						tileStatus[0] == 1 && 
						tileStatus[1] == 1 && 
						tileStatus[2] == 1 && 
						tileStatus[3] == 1 && 
						tileStatus[4] == 1 &&
						tileStatus[5] == 1 &&  
						tileStatus[6] == 1 &&  
						tileStatus[7] == 1 && 
						tileStatus[8] == 1){

						    Console.WriteLine("Game Over. The game resulted in a tie.");                            						    
                            Console.WriteLine("Would you like to play again? 1 = Yes or 0 = No?");
							Console.Write("Enter your choice: ");
                            userInput = Console.ReadLine();
						    if(userInput == "1"){
                            gameNumber++;
							tieCounter++;
                            turnNumber = 0;
                            resetLists();
                            continue;
                        }
                        else if(userInput == "0"){
                            gameOver = 1;
                            break;
                        }else{
                            invalidInputMessageForReset();
                            continue;
                        }
						

					}
				}

				Console.WriteLine();
				Console.Write("Please choose a tile: ");

				try{
					userInput = Console.ReadLine();		
				}catch(System.FormatException){
					Console.WriteLine();
					invalidInputMessageForTileInput();
					continue;
				}catch(System.OverflowException){
					Console.WriteLine();
					invalidInputMessageForTileInput();
					continue;
				}
						
				Console.WriteLine();

				if(turnNumber%2 == 0){			

					switch(userInput){

						case "1":
							if(tileStatus[0] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[0] = "X";
							turnNumber++;
							tileStatus[0] = 1;
							break;

						case "2":
							if(tileStatus[1] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[1] = "X";
							turnNumber++;
							tileStatus[1] = 1;
							break;

						case "3":
							if(tileStatus[2] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[2] = "X";
							turnNumber++;
							tileStatus[2] = 1;
							break;

						case "4":
							if(tileStatus[3] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[3] = "X";
							turnNumber++;
							tileStatus[3] = 1;
							break;

						case "5":
							if(tileStatus[4] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[4] = "X";
							turnNumber++;
							tileStatus[4] = 1;
							break;

						case "6":
							if(tileStatus[5] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[5] = "X";
							turnNumber++;
							tileStatus[5] = 1;
							break;

						case "7":
							if(tileStatus[6] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[6] = "X";
							turnNumber++;
							tileStatus[6] = 1;
							break;

						case "8":
							if(tileStatus[7] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[7] = "X";
							turnNumber++;
							tileStatus[7] = 1;
							break;
						
						case "9":
							if(tileStatus[8] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[8] = "X";
							turnNumber++;
							tileStatus[8] = 1;
							break;	

						default:
							invalidInputMessageForTileInput();
							break;
						}
					}else{							

						switch(userInput){

						case "1":
							if(tileStatus[0] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[0] = "O";
							turnNumber++;
							tileStatus[0] = 1;
							break;

						case "2":
							if(tileStatus[1] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[1] = "O";
							turnNumber++;
							tileStatus[1] = 1;
							break;

						case "3":
							if(tileStatus[2] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[2] = "O";
							turnNumber++;
							tileStatus[2] = 1;
							break;

						case "4":
							if(tileStatus[3] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[3] = "O";
							turnNumber++;
							tileStatus[3] = 1;
							break;

						case "5":
							if(tileStatus[4] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[4] = "O";
							turnNumber++;
							tileStatus[4] = 1;
							break;

						case "6":
							if(tileStatus[5] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[5] = "O";
							turnNumber++;
							tileStatus[5] = 1;
							break;

						case "7":
							if(tileStatus[6] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[6] = "O";
							turnNumber++;
							tileStatus[6] = 1;
							break;

						case "8":
							if(tileStatus[7] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[7] = "O";
							turnNumber++;
							tileStatus[7] = 1;
							break;
						
						case "9":
							if(tileStatus[8] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[8] = "O";
							turnNumber++;
							tileStatus[8] = 1;
							break;	

						default:
							invalidInputMessageForTileInput();
							break;
					}
				}
			}
		}
	}
}