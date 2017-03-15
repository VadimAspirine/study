using System;

namespace Laba2 
{
	
	class MainLaba 
	{
		static void Main () 
		{
			Game3 game = new Game3 (1, 2, 3, 4, 5, 6, 7, 8, 0);
			Console.WriteLine (game.CheckVictoryGame());
			game.RandomizeGame();
			Console.WriteLine (game.CheckVictoryGame());
			
			for (int i = 0; i < game.GetLength(0); ++i) 
			{
				for (int j = 0; j < game.GetLength(1); ++j) 
				{
					Console.Write (game[i,j] + " ");
				}
				Console.Write ("\n");
			}		
			// test input from csv
			Game game1 = Game.InputFromCSV ("15.csv");
			Console.Write ("\n");
			for (int i = 0; i < game1.GetLength(0); ++i) 
			{
				for (int j = 0; j < game1.GetLength(1); ++j) 
				{
					Console.Write (game1[i,j] + " ");
				}
				Console.Write ("\n");
			}
			
		}
	}
	
}
