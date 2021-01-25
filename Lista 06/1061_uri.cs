using System;

class MainClass {
  public static void Main (string[] args) {
    string[] dia1 = Console.ReadLine().Split(' ');
    string[] horaInicio = Console.ReadLine().Split(' : ');
    string[] dia2 = Console.ReadLine().Split(' ');
    string[] horaFinal = Console.ReadLine().Split(' : ');

    int diaInicio = int.Parse(dia1[1]);
    int diaFinal = int.Parse(dia2[1]);

    int horaInicio = int.Parse(horaInicio[0]);
    int minutoInicio = int.Parse(horaInicio[1]);
    int segundoInicio = int.Parse(horaInicio[2]);

    int horaFinal = int.Parse(horaFinal[0]);
    int minutoFinal = int.Parse(horaFinal[1]);
    int segundoFinal = int.Parse(horaFinal[2]);

    int t1 = horaInicio * 

    // INCOMPLETO
  }
}