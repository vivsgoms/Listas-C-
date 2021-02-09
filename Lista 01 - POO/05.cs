using System;
class MainClass {
  public static void Main (string[] args) {
    cinema x;
    x = new cinema();
    Console.WriteLine("Digite o dia da semana");
    x.dia = Console.ReadLine();
    Console.WriteLine("Digite na hora da sessão no formato hh:mm");
    string[] t = Console.ReadLine().Split(':');
    x.h = double.Parse(t[0]);
    Console.WriteLine("Valor = R$ " + x.ingresso());

  }
}
class cinema {
  public string dia;
  public double v, h;
  public double ingresso() {
    if (dia == "Segunda" || dia == "Terça" || dia == "Quinta") v = 16;
    if (dia == "Quarta") v = 8;
    if (dia == "Sexta" || dia == "Sábado" || dia == "Domingo") v = 20;
    if (h >= 17 && h <= 24 && dia != "Quarta")
      return v + 50/100*v;
    else
      return v;
  }
}