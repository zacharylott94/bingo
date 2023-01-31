// See https://aka.ms/new-console-template for more information
using Bingo;

// Random rnd = new Random();

// for (int i = 0; i < 1000; i++){
//   int board = rnd.Next(0,Board.FULL_BOARD);
//   if (Board.hasExactNumberFilled(board,10)){
//     Board.Print(board);
//     Console.WriteLine();
//   }
// }

Board.WinSpace(10,Board.hasExactNumberFilled);
Board.WinSpace(10,Board.hasAtMostNumberFilled);
Board.WinSpace(10,Board.hasAtLeastNumberFilled);