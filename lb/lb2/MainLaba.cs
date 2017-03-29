using System;

namespace Laba2 {
	
	class MainLaba {
		static void Main () {
/*			Console.WriteLine ("------------Basic_functions-test--------------");
			Game3 game = new Game3 (1, 2, 3, 4, 5, 6, 7, 8, 0);
			Console.WriteLine (game.CheckVictoryGame());
//			game.RandomizeGame();
//			Console.WriteLine (game.CheckVictoryGame());
			
			for (int i = 0; i < game.GetLength(0); ++i) {
				for (int j = 0; j < game.GetLength(1); ++j) {
					Console.Write (game[i,j] + " ");
					}
				Console.Write ("\n");
				}

			Console.Write ("(6)\n");
			game.Shift (6);
			for (int i = 0; i < game.GetLength(0); ++i) {
				for (int j = 0; j < game.GetLength(1); ++j) {
					Console.Write (game[i,j] + " ");
					}
				Console.Write ("\n");
				}
			
			Console.Write ("(5)\n");
			game.Shift (5);
			for (int i = 0; i < game.GetLength(0); ++i) {
				for (int j = 0; j < game.GetLength(1); ++j) {
					Console.Write (game[i,j] + " ");
					}
				Console.Write ("\n");
				}
				
			Console.Write ("(2)\n");
			game.Shift (2);
			for (int i = 0; i < game.GetLength(0); ++i) {
				for (int j = 0; j < game.GetLength(1); ++j) {
					Console.Write (game[i,j] + " ");
					}
				Console.Write ("\n");
				}
			
			Console.WriteLine ("---------------Undo-Redo-test-----------------");
			game.Undo ();
			game.Undo ();
			game.Undo ();
			game.Redo ();
			game.Redo ();
			game.Redo ();
			game.Undo ();
			game.Undo ();
			game.Undo ();
			game.Redo ();
			for (int i = 0; i < game.GetLength(0); ++i) {
				for (int j = 0; j < game.GetLength(1); ++j) {
					Console.Write (game[i,j] + " ");
					}
				Console.Write ("\n");
				}
			
				
//			game.LoadGamePosition (0);
//			Console.Write ("На шаг назад\n");
//			
//			for (int i = 0; i < game.GetLength(0); ++i) {
//				for (int j = 0; j < game.GetLength(1); ++j) {
//					Console.Write (game[i,j] + " ");
//					}
//				Console.Write ("\n");
//				}
			
			// test input from csv
			Game game1 = Game.InputFromCSV ("15.csv");
			Console.Write ("\n");
			for (int i = 0; i < game1.GetLength(0); ++i) {
				for (int j = 0; j < game1.GetLength(1); ++j) {
					Console.Write (game1[i,j] + " ");
					}
				Console.Write ("\n");
				}
			
			Console.WriteLine ("--------------IPlayable-test------------------");
			List<IPlayable> games = new List<IPlayable>();
			games.Add (new Game3 (1, 2, 3, 4, 5, 6, 7, 8, 0));
			Console.WriteLine (games[0].CheckVictoryGame());
			games[0].RandomizeGame();
			Console.WriteLine (games[0].CheckVictoryGame());
			games.Add (new Game2 (1, 3, 2, 4, 5, 6, 7, 8, 0));
			Console.WriteLine (games[1].CheckVictoryGame());
			Console.WriteLine (games[1][0,2]);
*/			
//			Console.WriteLine ("------------ConsoleGameUI-test----------------");
			IPlayable gm = new Game3 (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 0);
			gm.RandomizeGame();
			ConsoleGameUI CG = new ConsoleGameUI (gm);
			CG.StartGame ();
			}
		}
	
	}
