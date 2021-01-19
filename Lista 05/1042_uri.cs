using System;

class MainClass {
  public static void Main (string[] args) {
    int a, b, c;

    string[] valores = Console.ReadLine().Split(' ');
    a = int.Parse(valores[0]);
    b = int.Parse(valores[1]);
    c = int.Parse(valores[2]);
    
    if (a > b && b > c) Console.WriteLine($"{c}\n{b}\n{a}");
    if (a > c && c > b) Console.WriteLine($"{b}\n{c}\n{a}");
    if (b > a && a > c) Console.WriteLine($"{c}\n{a}\n{b}");
    if (b > c && c > a) Console.WriteLine($"{a}\n{c}\n{b}");
    if (c > a && a > b) Console.WriteLine($"{b}\n{a}\n{c}");
    if (c > b && b > a) Console.WriteLine($"{a}\n{b}\n{c}");
    Console.WriteLine($"\n{a}\n{b}\n{c}");


  }
}