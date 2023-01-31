namespace Bingo
{
  using System;
  static class Board {

    public delegate bool BoardFillRequirement(int board, int filled);
    public delegate bool BoardWinRequirement(int board);
    private static String filled = "▓▓";
    private static String empty = "░░";

    public static int FULL_BOARD = 33554431;


    static public void Print(int board){
      for (int i = 0; i < 25; i++){
        if ((board & (1 << i)) == (1 << i)){
          Console.Write(filled);
        }
        else{
          Console.Write(empty);
        }
        if (i % 5 == 4){
          Console.Write("\n");
        }
      
      }
    }
    static public bool Wins(int board){
      foreach (var winState in winStates)
      {
        if((board & winState) == winState){
          return true;
        }
      }
      return false;
    }

    static public bool HasOneWin(int board){
      int count = 0;
      foreach (var winState in winStates)
      {
        if((board & winState) == winState){
          count ++;
          if (count > 1) {return false;}
        }
      }
      if (count == 1) {return true;}
      return false;
    }

    static public bool HasTwoWins(int board){
      int count = 0;
      foreach (var winState in winStates)
      {
        if((board & winState) == winState){
          count ++;
          if (count > 2) {return false;}
        }
      }
      if (count == 2) {return true;}
      return false;
    }
    static public bool hasExactNumberFilled(int board, int filled){
      int count = 0;
      for (int i = 0; i < 25; i++){
        int space = 1 << i;
        if ((board & space) == space) {
          count++;
          if (count > filled) {return false;}
        }
      }
      if (count == filled) {return true;}
      return false;
    }

    static public bool hasAtMostNumberFilled(int board, int filled){
      int count = 0;
      for (int i = 0; i < 25; i++){
        int space = 1 << i;
        if ((board & space) == space) {
          count++;
          if (count > filled) {return false;}
        }
      }
      return true;
    }

    static public bool hasAtLeastNumberFilled(int board, int filled){
      int count = 0;
      for (int i = 0; i < 25; i++){
        int space = 1 << i;
        if ((board & space) == space) {
          count++;
        }
      }
      if (count < filled){return false;}
      return true;
    }
    

    public static void WinSpace(int filled, BoardFillRequirement method, BoardWinRequirement winMethod){
      int win = 0;
      int loss = 0;
      for(int i = 0; i < FULL_BOARD+1; i++){
        if(method(i, filled)){
          if (winMethod(i)) {
            win++;
          }
          else{
            loss++;
          }
        }
      }
      Console.WriteLine($"Wins: {win}");
      Console.WriteLine($"Losses: {loss}");
      Console.WriteLine($"Chance for a random board to win: {(double)win / (loss + win)}");

    }

    public static int CountFilled(int board){
      int count = 0;
      for (int i = 0; i < 25; i++){
        int space = 1 << i;
        if ((board & space) == space) {
          count++;
        }
      }
      return count;
    }

    public static int[] winStates = new int[]{
      // ▓▓▓▓▓▓▓▓▓▓
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      0b11111,
    
      // ░░░░░░░░░░
      // ▓▓▓▓▓▓▓▓▓▓
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      0b1111100000,

      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ▓▓▓▓▓▓▓▓▓▓
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      0b111110000000000,

      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ▓▓▓▓▓▓▓▓▓▓
      // ░░░░░░░░░░
      0b11111000000000000000,
      
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ░░░░░░░░░░
      // ▓▓▓▓▓▓▓▓▓▓
      0b1111100000000000000000000,

      // ░░░░░░░░▓▓
      // ░░░░░░░░▓▓
      // ░░░░░░░░▓▓
      // ░░░░░░░░▓▓
      // ░░░░░░░░▓▓
      0b1000010000100001000010000,

      // ░░░░░░▓▓░░
      // ░░░░░░▓▓░░
      // ░░░░░░▓▓░░
      // ░░░░░░▓▓░░
      // ░░░░░░▓▓░░

      0b0100001000010000100001000,

      // ░░░░▓▓░░░░
      // ░░░░▓▓░░░░
      // ░░░░▓▓░░░░
      // ░░░░▓▓░░░░
      // ░░░░▓▓░░░░

      0b0010000100001000010000100,

      // ░░▓▓░░░░░░
      // ░░▓▓░░░░░░
      // ░░▓▓░░░░░░
      // ░░▓▓░░░░░░
      // ░░▓▓░░░░░░

      0b0001000010000100001000010,

      // ▓▓░░░░░░░░
      // ▓▓░░░░░░░░
      // ▓▓░░░░░░░░
      // ▓▓░░░░░░░░
      // ▓▓░░░░░░░░

      0b0000100001000010000100001,

      // ▓▓░░░░░░░░
      // ░░▓▓░░░░░░
      // ░░░░▓▓░░░░
      // ░░░░░░▓▓░░
      // ░░░░░░░░▓▓

      0b0000100010001000100010000,

      // ░░░░░░░░▓▓
      // ░░░░░░▓▓░░
      // ░░░░▓▓░░░░
      // ░░▓▓░░░░░░
      // ▓▓░░░░░░░░

      0b1000001000001000001000001,
    };
  }
}