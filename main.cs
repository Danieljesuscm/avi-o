using System;

class MainClass {
  public static void Main () {
    aviao tur = new aviao("tur", 14000,9000,50,3000,120,"alberto","congonhas");
    Console.WriteLine($"O avião já percorreu >>{tur.voar(3000)}");
  }
  
}