using System;
class MainClass {
  public static void Main (string[] args) {
    disciplina a;
    a = new disciplina();
    Console.WriteLine("Digite o nome da disciplina");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite a nota do primeiro bimestre");
    a.n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre");
    a.n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do terceiro bimestre");
    a.n3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do quarto bimestre");
    a.n4 = int.Parse(Console.ReadLine());
    if (a.m() >= 60) {
      Console.WriteLine("Você foi aprovado em {nome} com média" + a.m());
    }
    else {
      Console.WriteLine($"Digite a nota da prova final");
      a.nf = int.Parse(Console.ReadLine());
      Console.WriteLine($"Nota final em  {nome} = " + a.m2());
    }
  }
}
class disciplina {
  public double n1, n2, n3, n4, nf, media;
  public double m() {
    media = (n1 * 2 + n2 * 2 + n3 * 3 + n4 * 3) / 10;
    return media;
  }
  public double m2() {
    return (media + nf) / 2;
  }
}