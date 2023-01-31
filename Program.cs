// See https://aka.ms/new-console-template for more information
using Bingo;

Random rnd = new Random();

for (int i = 0; i < 10; i++){
  int board = rnd.Next(0,Board.FULL_BOARD);
  Board.Print(board);
  Console.WriteLine($"Spaces Filled: {Board.CountFilled(board)}");
  Console.WriteLine();
}

