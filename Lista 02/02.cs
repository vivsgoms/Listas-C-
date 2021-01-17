using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o seu nome completo");
    string[] nomeCompleto = Console.ReadLine().Split();
    Console.WriteLine($"Bem-vindo ao C#, {nomeCompleto[0]}";
  }
}
