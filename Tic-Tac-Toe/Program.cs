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

		static string player1Character = "X";
		static string player2Character = "O";

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

		static void player1_WinnerMessage(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game Over. Player " + player1Character + " won!");
			Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
			Console.WriteLine("Would you like to play again? 1 = Yes or 0 = No?");
			Console.Write("Enter your choice: ");
        }                    

        static void player2_WinnerMessage(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Game Over. Player " + player2Character + " won!");
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
            Console.WriteLine("!!! Invalid input: Please choose either 1 for yes and 0 for no only !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void invalidInputMessageForTileInput(){
            Console.ForegroundColor = ConsoleColor.Red;		
			Console.Beep();
			Console.Beep();
            Console.WriteLine("!!! Invalid input: Please choose a number from 1 to 9 only !!!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void invalidInputMessageForFilledTile(){
            Console.ForegroundColor = ConsoleColor.Red;
			Console.Beep();
			Console.Beep();
            Console.WriteLine("!!! Tile is already filled: Please Choose a different tile !!!");
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
			bool willChooseCustomCharacter1 = false;
			bool willChooseCustomCharacter2 = false;
			bool hasChosenCharacter1 = false;
			bool hasChosenCharacter2 = false;			
            int gameNumber = 1;
			int tieCounter = 0;

            int player1_Wins = 0;
            int player2_Wins = 0;			
			/*
			Acts as both a turn counter and to determine whether it is player X or O's turn. 
			Turn numbers with even values are turns for player X while turn numbers with odd values are for player O.
			*/
			int turnNumber = 0;

			// Initializing user input
			string userInput = "0";

            initializeLists();                                			          

			Console.Clear();

			while(willChooseCustomCharacter1 == false){ 	
				Console.WriteLine();
				Console.WriteLine("Tic-Tac-Toe");	
				Console.WriteLine();		
				Console.WriteLine("Current Avatars:");
				Console.WriteLine("Player 1: " + player1Character);
				Console.WriteLine("Player 2: " + player2Character);			
				
				Console.WriteLine();

				Console.WriteLine("Would you like to choose a custom avatar for player 1?");
				Console.WriteLine("1 = Yes | 0 = No");
				Console.Write("Enter your choice: ");
				userInput = Console.ReadLine();

				if(userInput != "1" && userInput != "0"){
					Console.Beep();
					Console.Beep();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine();
					Console.WriteLine("!!! Invalid input: Please choose either 1 or 0 only !!!");
					Console.ForegroundColor = ConsoleColor.White;
				}else if(userInput == "1"){
					willChooseCustomCharacter1 = true;
				}else{
					break;
				}
			}


			if(willChooseCustomCharacter1 == true){

				while(hasChosenCharacter1 == false){
					Console.WriteLine();
					Console.Write("Choose a letter for player 1: ");					
					player1Character = Console.ReadLine();
					bool lengthSatisfiedCharacter1 = true;
					bool formatSatisfiedCharacter1 = true;										
					
					if(player1Character.Length > 1){						
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Please use one character only !!!");
						Console.ForegroundColor = ConsoleColor.White;						
						lengthSatisfiedCharacter1 = false;
					}if(player1Character.Length < 0){
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Please choose a character !!!");
						Console.ForegroundColor = ConsoleColor.White;						
						lengthSatisfiedCharacter1 = false;
					}
					if(
					player1Character != "A" &&
					player1Character != "B"	&&
					player1Character != "C"	&&
					player1Character != "D"	&&
					player1Character != "E"	&&
					player1Character != "F" &&
					player1Character != "G"	&&
					player1Character != "H"	&&
					player1Character != "I"	&&
					player1Character != "J" &&
					player1Character != "K" &&
					player1Character != "L"	&&
					player1Character != "M"	&&
					player1Character != "N"	&&
					player1Character != "O"	&&
					player1Character != "P" &&
					player1Character != "Q"	&&
					player1Character != "R"	&&
					player1Character != "S"	&&
					player1Character != "T" &&
					player1Character != "U" &&
					player1Character != "V"	&&
					player1Character != "W"	&&
					player1Character != "X"	&&
					player1Character != "Y"	&&
					player1Character != "Z" &&
					player1Character != "a"	&&
					player1Character != "b"	&&
					player1Character != "c"	&&
					player1Character != "d" &&
					player1Character != "e" &&
					player1Character != "f"	&&
					player1Character != "g"	&&
					player1Character != "h"	&&
					player1Character != "i"	&&
					player1Character != "j" &&
					player1Character != "k"	&&
					player1Character != "l"	&&
					player1Character != "m"	&&
					player1Character != "n" &&
					player1Character != "o" &&
					player1Character != "p"	&&
					player1Character != "q"	&&
					player1Character != "r"	&&
					player1Character != "s"	&&
					player1Character != "t" &&
					player1Character != "u"	&&
					player1Character != "v"	&&
					player1Character != "w"	&&
					player1Character != "x" &&
					player1Character != "y"	&&
					player1Character != "z"){						
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;						
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Please choose a single letter only !!!");
						Console.ForegroundColor = ConsoleColor.White;
						formatSatisfiedCharacter1 = false;												
					}else if(lengthSatisfiedCharacter1 && formatSatisfiedCharacter1){
						hasChosenCharacter1 = true;
					}
				}
			}			

			while(willChooseCustomCharacter2 == false){ 	
				Console.WriteLine();
				Console.WriteLine("Tic-Tac-Toe");	
				Console.WriteLine();		
				Console.WriteLine("Current Avatars:");
				Console.WriteLine("Player 1: " + player1Character);
				Console.WriteLine("Player 2: " + player2Character);			
				
				Console.WriteLine();

				Console.WriteLine("Would you like to choose a custom avatar for player 2?");
				Console.WriteLine("1 = Yes | 0 = No");
				Console.Write("Enter your choice: ");
				userInput = Console.ReadLine();

				if(userInput != "1" && userInput != "0"){
					Console.Beep();
					Console.Beep();
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine();
					Console.WriteLine("!!! Invalid input: Please choose either 1 or 0 only !!!");
					Console.ForegroundColor = ConsoleColor.White;
				}else if(userInput == "1"){
					willChooseCustomCharacter2 = true;
				}else{
					break;
				}
			}


			if(willChooseCustomCharacter2 == true){

				while(hasChosenCharacter2 == false){
					Console.WriteLine();
					Console.Write("Choose a letter for player 2: ");					
					player2Character = Console.ReadLine();
					bool lengthSatisfiedCharacter2 = true;
					bool formatSatisfiedCharacter2 = true;										
					
					if(player2Character.Length > 1){						
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Please use one character only !!!");
						Console.ForegroundColor = ConsoleColor.White;						
						lengthSatisfiedCharacter2 = false;
					}if(player2Character.Length < 0){
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Please choose a character !!!");
						Console.ForegroundColor = ConsoleColor.White;						
						lengthSatisfiedCharacter2 = false;
					}
					if(player2Character == player1Character){
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Player 1 and player 2 cannot have the same character !!!");
						Console.ForegroundColor = ConsoleColor.White;						
						lengthSatisfiedCharacter2 = false;
						formatSatisfiedCharacter2 = false;
						lengthSatisfiedCharacter2 = false;
					}
					if(
					player2Character != "A" &&
					player2Character != "B"	&&
					player2Character != "C"	&&
					player2Character != "D"	&&
					player2Character != "E"	&&
					player2Character != "F" &&
					player2Character != "G"	&&
					player2Character != "H"	&&
					player2Character != "I"	&&
					player2Character != "J" &&
					player2Character != "K" &&
					player2Character != "L"	&&
					player2Character != "M"	&&
					player2Character != "N"	&&
					player2Character != "O"	&&
					player2Character != "P" &&
					player2Character != "Q"	&&
					player2Character != "R"	&&
					player2Character != "S"	&&
					player2Character != "T" &&
					player2Character != "U" &&
					player2Character != "V"	&&
					player2Character != "W"	&&
					player2Character != "X"	&&
					player2Character != "Y"	&&
					player2Character != "Z" &&
					player2Character != "a"	&&
					player2Character != "b"	&&
					player2Character != "c"	&&
					player2Character != "d" &&
					player2Character != "e" &&
					player2Character != "f"	&&
					player2Character != "g"	&&
					player2Character != "h"	&&
					player2Character != "i"	&&
					player2Character != "j" &&
					player2Character != "k"	&&
					player2Character != "l"	&&
					player2Character != "m"	&&
					player2Character != "n" &&
					player2Character != "o" &&
					player2Character != "p"	&&
					player2Character != "q"	&&
					player2Character != "r"	&&
					player2Character != "s"	&&
					player2Character != "t" &&
					player2Character != "u"	&&
					player2Character != "v"	&&
					player2Character != "w"	&&
					player2Character != "x" &&
					player2Character != "y"	&&
					player2Character != "z"){						
						Console.Beep();
						Console.Beep();
						Console.ForegroundColor = ConsoleColor.Red;						
						Console.WriteLine();
						Console.WriteLine("!!! Invalid Input: Please choose a single letter only !!!");
						Console.ForegroundColor = ConsoleColor.White;
						formatSatisfiedCharacter2 = false;												
					}else if(lengthSatisfiedCharacter2 && formatSatisfiedCharacter2){
						hasChosenCharacter2 = true;
					}
				}
			}

			while(gameOver == 0){				      

				Console.WriteLine();
                Console.WriteLine("Number of Games: " + gameNumber);
				Console.WriteLine("Turn Number: " + (turnNumber+1));
                Console.WriteLine("Player " + player1Character + " Wins: " + player1_Wins);
                Console.WriteLine("Player " + player2Character + " Wins: " + player2_Wins);
				Console.WriteLine("Number of ties: " + tieCounter);
				Console.WriteLine();
				// Turn numbers with even values are turns for player X while turn numbers with odd values are for player O.
				if(turnNumber%2 == 0){
					Console.Write("Player ");
					Console.ForegroundColor = ConsoleColor.DarkYellow;
					Console.Write(player1Character);
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("'s Turn");
				}else{
					Console.Write("Player ");
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write(player2Character);
					Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("'s Turn");
				}

				Console.WriteLine();
				Console.WriteLine("-------------------");
				
				for(int loop = 0; loop <= 8; loop++){		

					if(loop%3 == 0){						
						Console.Write("|");
					}

					if(tile[loop] == player1Character){
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.Write("  " + tile[loop] + "  ");
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write("|");
					}else if(tile[loop] == player2Character){
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
						player2_WinnerMessage();						
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player2_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player2_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
						player1_WinnerMessage();
                        userInput = Console.ReadLine();
						if(userInput == "1"){
                            gameNumber++;
                            player1_Wins++;
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
							tile[0] = player1Character;
							turnNumber++;
							tileStatus[0] = 1;
							break;

						case "2":
							if(tileStatus[1] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[1] = player1Character;
							turnNumber++;
							tileStatus[1] = 1;
							break;

						case "3":
							if(tileStatus[2] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[2] = player1Character;
							turnNumber++;
							tileStatus[2] = 1;
							break;

						case "4":
							if(tileStatus[3] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[3] = player1Character;
							turnNumber++;
							tileStatus[3] = 1;
							break;

						case "5":
							if(tileStatus[4] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[4] = player1Character;
							turnNumber++;
							tileStatus[4] = 1;
							break;

						case "6":
							if(tileStatus[5] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[5] = player1Character;
							turnNumber++;
							tileStatus[5] = 1;
							break;

						case "7":
							if(tileStatus[6] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[6] = player1Character;
							turnNumber++;
							tileStatus[6] = 1;
							break;

						case "8":
							if(tileStatus[7] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[7] = player1Character;
							turnNumber++;
							tileStatus[7] = 1;
							break;
						
						case "9":
							if(tileStatus[8] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[8] = player1Character;
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
							tile[0] = player2Character;
							turnNumber++;
							tileStatus[0] = 1;
							break;

						case "2":
							if(tileStatus[1] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[1] = player2Character;
							turnNumber++;
							tileStatus[1] = 1;
							break;

						case "3":
							if(tileStatus[2] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[2] = player2Character;
							turnNumber++;
							tileStatus[2] = 1;
							break;

						case "4":
							if(tileStatus[3] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[3] = player2Character;
							turnNumber++;
							tileStatus[3] = 1;
							break;

						case "5":
							if(tileStatus[4] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[4] = player2Character;
							turnNumber++;
							tileStatus[4] = 1;
							break;

						case "6":
							if(tileStatus[5] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[5] = player2Character;
							turnNumber++;
							tileStatus[5] = 1;
							break;

						case "7":
							if(tileStatus[6] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[6] = player2Character;
							turnNumber++;
							tileStatus[6] = 1;
							break;

						case "8":
							if(tileStatus[7] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[7] = player2Character;
							turnNumber++;
							tileStatus[7] = 1;
							break;
						
						case "9":
							if(tileStatus[8] == 1){
								invalidInputMessageForFilledTile();
								break;
							}
							tile[8] = player2Character;
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