using System;

class MainClass {
  public static int mdc(int a, int b) {
    while (b != 0) {
      int r = a % b;
      a = b;
      b = r;
    }
    return a;
  }
  public static int mmc(int a, int b) {
    return a * (b / mdc(a, b));
  }
  public static void Main (string[] args) {
  Console.WriteLine(mmc(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

}
}
