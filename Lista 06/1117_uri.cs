using System;

class MainClass {
  public static void Main (string[] args) {
    double nota = double.Parse(Console.ReadLine());
    if (nota < 0 || nota > 10) Console.WriteLine("nota invalida");
    
    while (nota < 0  || nota > 10) {
      nota = double.Parse(Console.ReadLine());
       if (nota < 0 || nota > 10) Console.WriteLine("nota invalida");
    }

    double nota2 = double.Parse(Console.ReadLine());
      if (nota2 < 0 || nota2 > 10) Console.WriteLine("nota invalida");
    while (nota2 < 0  || nota2 > 10) {
      nota2 = double.Parse(Console.ReadLine());
       if (nota2 < 0 || nota2 > 10) Console.WriteLine("nota invalida");
    }

    double media = (nota + nota2) / 2;

    Console.WriteLine($"media = {media:0.00}");
  }
}