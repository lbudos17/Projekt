namespace Program {
  class Application : Util {
    static void Main(string [] args) {
      IFizicka fizicka = new FizickeOsobe();
      IOsoba pravna = new PravneOsobe();
      ispis(pravna);
      //Util.ispis(fizicka);
      ispisOsobe(fizicka);

    }
  } 

  class Util 
  {
    protected static void ispis(IOsoba osoba) 
    {
        Console.WriteLine(osoba.adresa);
        Console.WriteLine(osoba.grad);
        Console.WriteLine(osoba.telefon);
    }
    public static void ispisOsobe( IFizicka osoba) 
    {
        Console.WriteLine(osoba.ime);
        Console.WriteLine(osoba.prezime);
    }
  }   
}


  












 



















