using System;
  class MainClass {
    public static void Main (string[] args) {
      banco x;
      x = new banco();
      Console.WriteLine("Digite o seu saldo total");
      x.saldo = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite 1 para depósito e 2 para saque");
      int n = int.Parse(Console.ReadLine());
      if (n == 1) {
        Console.WriteLine("Digite o valor que você gostaria de depositar");
        x.valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Total = " + x.deposito());
      }
      else {
         Console.WriteLine("Digite o valor que você gostaria de sacar");
        x.valor = double.Parse(Console.ReadLine());
        Console.WriteLine("Total = " + x.saque());
      }
    }
  }
  class banco {
    public double saldo, valor;
    public double deposito() {
      return saldo + valor;
    }
    public double saque() {
      return saldo - valor;
    }
  }
