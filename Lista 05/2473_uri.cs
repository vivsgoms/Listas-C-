using System;

class MainClass {
  public static void Main (string[] args) {
    int acertos=0,numero=0,numero2=0,x,y;
    string r = ("");
    
    string[] a = Console.ReadLine().Split(' ');
    string[] b = Console.ReadLine().Split(' ');

    for (x=numero; x<6; x=x+1 ) 
    for (y=numero2; y<6; y=y+1)
   
    if (a[x] == b[y])
        acertos = acertos + 1;

    if (acertos<3)
      r = "azar";
    if (acertos==3)
      r = "terno";
    if (acertos==4)
      r = "quadra";
    if (acertos==5)
      r = "quina";
    if (acertos==6)
      r = "sena";

    Console.WriteLine(r);
      
  }
}