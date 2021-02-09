using System;

class MainClass {
  public static void Main (string[] args) {
    int max = int.Parse(Console.ReadLine());
   // int x = 0, numero;
    int n;
   // while (x < max) {
    for (int i = 0; i < max; i++) {
     // int aux = 0;
      n = int.Parse(Console.ReadLine());
      bool p = true;
      for (int y = 2; p && y <= Math.Sqrt(n); y++) {
        if (n % y == 0) p = false;
          //aux += 1;
      }
      if (p) Console.WriteLine("Prime");
      else Console.WriteLine("Not Prime");
      //x += 1;
      
    }
  }
}