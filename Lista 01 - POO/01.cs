using System;
  class MainClass {
      public static void Main (string[] args) {
      areaC a;
      a = new areaC();
      Console.WriteLine("Digite o raio");
      a.r = double.Parse(Console.ReadLine());
      Console.WriteLine("Área = " + a.area());
      Console.WriteLine("Circunferência = " + a.c());
    }
  }
  class areaC {
    public double r;
    public double area() {
      return 3.14 * (r*r);
    }
    public double c() {
      return 2 * 3.14 * r;
    }

  }

