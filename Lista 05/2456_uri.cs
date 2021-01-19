using System;

class MainClass {
  public static void Main (string[] args) {
    int a, b, c, d, e;

    string[] valores = Console.ReadLine().Split(' ');
    a = int.Parse(valores[0]);
    b = int.Parse(valores[1]);
    c = int.Parse(valores[2]);
    d = int.Parse(valores[3]);
    e = int.Parse(valores[4]);

    if (a < b && b < c && c < d && d < e)
      Console.WriteLine("C");
    else
      if (a > b && b > c && c > d && d > e)
        Console.WriteLine("D");
      else
        Console.WriteLine("N");
    
  }
}