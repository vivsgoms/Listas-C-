using System;

class MainClass {
  public static double Maior(double x, double y) {

    double m = Math.Max(x,y);
    return m;
  }
  public static void Main(string[] args) {
    Console.WriteLine(Maior(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
  }
}