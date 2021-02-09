using System;

class MainClass {
  public static void Main (string[] args) {
    string dia1 = Console.ReadLine();
    string h1 = Console.ReadLine();
    string dia2 = Console.ReadLine();
    string horaFinal = Console.ReadLine();

    int diaInicio = int.Parse(dia1.Substring(4));
    int diaFinal = int.Parse(dia2.Substring(4));

    int h = int.Parse(h1.Substring(0,2));
    int minutoInicio = int.Parse(h1.Substring(5,2));
    int segundoInicio = int.Parse(h1.Substring(10,2));

    int h2 = int.Parse(horaFinal.Substring(0,2));
    int minutoFinal = int.Parse(horaFinal.Substring(5,2));
    int segundoFinal = int.Parse(horaFinal.Substring(10,2));

    int t1 = diaInicio * 86400 + h * 3600 + minutoInicio * 60 + segundoInicio;
    int t2 = diaFinal * 86400 + h2 * 3600 + minutoFinal * 60 + segundoFinal;

    int dif = t2 - t1;

    int nd = dif / 86400;
    dif = dif % 86400;

    int nh = dif / 3600;
    dif = dif % 3600;

    int nm = dif / 60;
    dif = dif % 60;

    Console.WriteLine($"{nd} dia(s)\n{nh} hora(s)\n{nm} minuto(s)\n{dif} segundo(s)");
  }
}D