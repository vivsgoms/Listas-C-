using System;

class MainClass {
  public static void Main () {

    string x = Console.ReadLine();
    while (x != "*") {
      x = x.ToLower();
      char c = x[0];
      bool ok = true;
      for (int i = 1; i < x.Length; i++) {
        if(x[i] == ' ' && x[i+1] != c) 
          ok = false;
      }
        
      if (ok) Console.WriteLine("Y");
      else Console.WriteLine("N");
      x = Console.ReadLine();
      
    }
  }
}