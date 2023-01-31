namespace Bingo
{
  using System;
  static class Board {
    private static String filled = "▓▓";
    private static String empty = "░░";



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

    public static void winSpace(){
      int win = 0;
      int loss = 0;
      for(int i = 0; i < 33554431; i++){
        if (Board.Wins(i)) {
          win++;
        }
        else{
          loss++;
        }
      }
      Console.WriteLine($"Wins: {win}");
      Console.WriteLine($"Losses: {loss}");
      Console.WriteLine($"Chance for a random board to win: {(double)win / (loss + win)}");

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