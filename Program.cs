namespace Program {
  class Application {
    static void Main(string [] args) {
      MainMenu menu = new MainMenu ();
      string prijevoz = menu.TravelVehicle();
      string destinacija = menu.TravelDestination();
      string smjestaj = menu.TravelAccommodation();
      
     Travel player = new Travel (prijevoz, destinacija, smjestaj);
      player.print();

    }
  }    
}


  












 



















