using System;
using static System.Math;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o intervalo de tempo no formato HH:MM:SS");
    string[] tempo = Console.ReadLine().Split(':');
    int horas = int.Parse(tempo[0]);
    int minutos = int.Parse(tempo[1]);
    int segundos = int.Parse(tempo[2]);
    long soma = (horas*3600) + (minutos*60) + segundos;
    long distancia = 300000*soma;
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");


  }
}
