using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a nota do primeiro bimestre");
    int primeiroBimestre = int.Parse(Console.ReadLine());
    Console.WriteLine ("Digite a nota do segundo bimeste");
    int segundoBimestre = int.Parse(Console.ReadLine());
    double media = (primeiroBimestre + segundoBimestre) / 2;
    Console.WriteLine($"Média parcial = {media}");
  }
}
