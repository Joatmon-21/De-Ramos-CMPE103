/* 
Written By: Dan Jandel C. De Ramos
Polytechnic University of the Philippines Biñan Campus
BSCpE 1-1 2nd Semester
*/

using System;

namespace test{
	
	class Program{
		
		static void Main(string[]args){
			
			int winner = 0;

			int userInput;

			int turnNumber = 0;

			string tile1 = "1";
			string tile2 = "2";
			string tile3 = "3";
			string tile4 = "4";
			string tile5 = "5";
			string tile6 = "6";
			string tile7 = "7";
			string tile8 = "8";
			string tile9 = "9";

			int tile1Status = 0;
			int tile2Status = 0;
			int tile3Status = 0;
			int tile4Status = 0;
			int tile5Status = 0;
			int tile6Status = 0;
			int tile7Status = 0;
			int tile8Status = 0;
			int tile9Status = 0;


				
			while(winner == 0){
				Console.WriteLine();
				Console.WriteLine("Turn Number: " + (turnNumber+1));
				if(turnNumber%2 == 0){
					Console.WriteLine("Player X's Turn");
				}else{
					Console.WriteLine("Player O's Turn");
				}
				Console.WriteLine();
				Console.WriteLine("-------------------");
				Console.WriteLine("|  " + tile1 + "  |  " + tile2 + "  |  " +  tile3  + "  |");
				Console.WriteLine("-------------------");
				Console.WriteLine("|  " + tile4 + "  |  " + tile5 + "  |  " +  tile6  + "  |");
				Console.WriteLine("-------------------");
				Console.WriteLine("|  " + tile7 + "  |  " + tile8 + "  |  " +  tile9  + "  |");
				Console.WriteLine("-------------------");
				Console.WriteLine();

				//where you put the winner checker				

				Console.Write("Please choose a tile: ");
				userInput = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine();

				
				

				if(turnNumber%2 == 0){			

					switch(userInput){

						case 1:
							if(tile1Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile1 = "X";
							turnNumber++;
							tile1Status = 1;
							break;

						case 2:
							if(tile2Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile2 = "X";
							turnNumber++;
							tile2Status = 1;
							break;

						case 3:
							if(tile3Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile3 = "X";
							turnNumber++;
							tile3Status = 1;
							break;

						case 4:
							if(tile4Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile4 = "X";
							turnNumber++;
							tile4Status = 1;
							break;

						case 5:
							if(tile5Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile5 = "X";
							turnNumber++;
							tile5Status = 1;
							break;

						case 6:
							if(tile6Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile6 = "X";
							turnNumber++;
							tile6Status = 1;
							break;

						case 7:
							if(tile7Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile7 = "X";
							turnNumber++;
							tile7Status = 1;
							break;

						case 8:
							if(tile8Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile8 = "X";
							turnNumber++;
							tile8Status = 1;
							break;
						
						case 9:
							if(tile9Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile9 = "X";
							turnNumber++;
							tile9Status = 1;
							break;	
						
						}

					}else{
						switch(userInput){

						case 1:
							if(tile1Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile1 = "O";
							turnNumber++;
							tile1Status = 1;
							break;

						case 2:
							if(tile2Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile2 = "O";
							turnNumber++;
							tile2Status = 1;
							break;

						case 3:
							if(tile3Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile3 = "O";
							turnNumber++;
							tile3Status = 1;
							break;

						case 4:
							if(tile4Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile4 = "O";
							turnNumber++;
							tile4Status = 1;
							break;

						case 5:
							if(tile5Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile5 = "O";
							turnNumber++;
							tile5Status = 1;
							break;

						case 6:
							if(tile6Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile6 = "O";
							turnNumber++;
							tile6Status = 1;
							break;

						case 7:
							if(tile7Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile7 = "O";
							turnNumber++;
							tile7Status = 1;
							break;

						case 8:
							if(tile8Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile8 = "O";
							turnNumber++;
							tile8Status = 1;
							break;
						
						case 9:
							if(tile9Status == 1){
								Console.WriteLine("Tile is already filled. Please Choose a different tile");
								break;
							}
							tile9 = "O";
							turnNumber++;
							tile9Status = 1;
							break;	
						
					}
				}
			}
		}
	}
}