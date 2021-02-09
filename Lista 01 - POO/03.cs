using System;
class MainClass {
  public static void Main (string[] args) {
    velocidade y;
    y = new velocidade();
    Console.WriteLine("Digite a distância em km");
    y.distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o tempo no formato hh:mm");
    string[] t = Console.ReadLine().Split(':');
    int h = int.Parse(t[0]);
    int m = int.Parse(t[1]);
    y.tempo = h + (m/60);
    Console.WriteLine("A velocidade média foi de " + y.v());
  }
}
class velocidade {
  public double distancia, tempo;
  public double v() {
    return distancia / tempo;
  }
}