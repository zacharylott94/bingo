// See https://aka.ms/new-console-template for more information
using Bingo;
// Console.WriteLine("Given boards that have exactly 10 spaces filled, and assuming the 10th space is the win...");
// Board.WinSpace(10,Board.hasExactNumberFilled,Board.HasOneWin);

// Console.WriteLine("Given boards that have exactly 16 spaces filled, and assuming the 16th space is the win...");
// Board.WinSpace(16,Board.hasExactNumberFilled,Board.HasOneWin);

// Console.WriteLine("Given all boards, and boards need exactly two win conditions...");
// Board.WinSpace(25,Board.hasAtMostNumberFilled,Board.HasTwoWins);

//Probably the most expensive computation
Board.WinSpace(5,Board.hasAtLeastNumberFilled,Board.Wins);