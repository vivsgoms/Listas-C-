using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o nome do estado:");
    string estado = Console.ReadLine();
    Console.WriteLine("Digite o número de habitantes:");
    int hab = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a área do estado em Km2");
    double area = double.Parse(Console.ReadLine());

    double d = hab / area;

    Console.WriteLine($"A densidade demográfica do {estado} é de {d:0.0} hab/Km2");
  }
}