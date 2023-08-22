using System.Reflection.Metadata;

namespace Program 
{
  class MainMenu
  {
    private string vehicleClass;
    public string TravelVehicle() 
    {
      bool running = true;
      do {
      //izbornik
      Console.WriteLine("1. Avion");
      Console.WriteLine("2. Vlak");
      Console.WriteLine("3. Autobus");
      Console.WriteLine("\nUpišite broj klase prijevoznog sredstva kojim želite putovati: ");

      //Korisnik bira klasu
      string key = Console.ReadLine();
      int choice = key == "" ? 0 : int.Parse(key);

      //Ako izbor nije 1 ili 2, prekini rad aplikacije
      if (choice == 1) 
      {
        Console.WriteLine("\nOdabrali ste klasu: Avion");
        vehicleClass = "Avion";
        running = false;
      }
      else if (choice == 2) 
      {
        Console.WriteLine("\nOdabrali ste klasu: Vlak");
        vehicleClass = "Vlak";
        running = false;
      }
      else if (choice == 3) 
      {
        Console.WriteLine("\nOdabrali ste klasu: Autobus");
        vehicleClass = "Autobus";
        running = false;
      }
      else 
      {
        Console.WriteLine("\nNedozvoljeni unos! Probajte ponovno.");
      }
      } while (running);

      return vehicleClass;
    }
    public string TravelDestination() 
    {
      string name;
      bool running = true;
      do 
      {
      //Ako je izbor u redu, pitaš korisnika za ime destinacije
      Console.WriteLine("\n************************************");
      Console.WriteLine("\nUpišite naziv Vaše destinacije: ");
      name = Console.ReadLine();

      
      if (name == null || name == "") 
      {
        Console.WriteLine("\nGreška! Niste unijeli naziv Vaše destinacije. Probajte ponovno.");
      
      }
      else 
      {
        running = false;
      }
      }while (running);

      return name;
    } 
    private string accommClass;
    public string TravelAccommodation() 
    {
      bool running = true;
      do {
        Console.WriteLine("Hotel");
        Console.WriteLine("Apartman");
        Console.WriteLine("Vikendica");
        Console.WriteLine("\nUpište broj klase smještaja koji želite odabrati.");

        string key = Console.ReadLine();
        int choice = key == "" ? 0 : int.Parse(key);

        if (choice == 1) 
        {
          Console.WriteLine("\nOdabrali ste klasu: Hotel");
          accommClass = "Hotel";
          running = false;
        }
        else if (choice == 2) 
        {
          Console.WriteLine("\nOdabrali ste klasu: Apartman");
          accommClass = "Apartman";
          running = false;
        }
        else if (choice == 3) 
        {
          Console.WriteLine("\nOdabrali ste klasu: Vikendica");
          accommClass= "Vikendica";
          running = false;
        }
        else 
        {
          Console.WriteLine("\nNedozvoljeni unos! Probajte ponovno.");

        }
      }while (running);
      return accommClass;
    }  
    

   

  }

}