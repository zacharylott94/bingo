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
  }
}