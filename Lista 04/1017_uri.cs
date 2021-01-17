using System;

class MainClass {
  public static void Main (string[] args) {
    int tempo, velocidade;
    double distancia, litros;
    tempo = int.Parse(Console.ReadLine());
    velocidade = int.Parse(Console.ReadLine());
    distancia = velocidade * tempo;
    litros = distancia / 12;
    Console.WriteLine($"{litros:0.000}");
  }
}