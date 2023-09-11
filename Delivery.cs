namespace Program {
   
         public interface Delivery
{
          public string TypeDelivery {get; set;}
         public string Name {get; set;}
         public string Adress { get; set;}
         public DateTime Date { get; set;}
         void Deliver();
}

        public class PostDelivery : Delivery
    {
        public string TypeDelivery {get; set;}
        public string Name {get; set;}
        public string Adress {get; set;}
        public DateTime Date {get; set;}

        public PostDelivery (string Name, string Adress, DateTime Date) 
        {
            this.TypeDelivery = "Dostava poštom";
            this.Name = Name;
            this.Adress = Adress; 
            this.Date = Date;
        }
        public void Deliver() 
        {
            Console.WriteLine("Informacije o dostavi:");
            Console.WriteLine($"Način dostave: {TypeDelivery}");
            Console.WriteLine($"Ime primatelja: {Name}");
            Console.WriteLine($"Adresa dostave: {Adress}");
            Console.WriteLine($"Datum dostave: {Date:d}");
        }
    }
    public class CourierDelivery : Delivery 
    {
        public string TypeDelivery {get; set;}
        public string Name {get; set;}
        public string Adress {get; set;}
        public DateTime Date {get; set;}

        public CourierDelivery (string Name, string Adress, DateTime Date) 
        {
            this.TypeDelivery = "Dostava kurirskom službom";
            this.Name = Name;
            this.Adress = Adress; 
            this.Date = Date;
        }
        public void Deliver() 
        {
            Console.WriteLine("Informacije o dostavi:");
            Console.WriteLine($"Način dostave: {TypeDelivery}");
            Console.WriteLine($"Ime primatelja: {Name}");
            Console.WriteLine($"Adresa dostave: {Adress}");
            Console.WriteLine($"Datum dostave: {Date:d}");
        }
    }
    public class PickupDelivery : Delivery
    {
       public string TypeDelivery {get; set;}
        public string Name {get; set;}
        public string Adress {get; set;}
        public DateTime Date {get; set;}

        public PickupDelivery (string Name, string Adress, DateTime Date) 
        {
            this.TypeDelivery = "Osobno preuzimanje";
            this.Name = Name;
            this.Adress = Adress; 
            this.Date = Date;
        }
        public void Deliver() 
        {
            Console.WriteLine("Informacije o dostavi:");
            Console.WriteLine($"Način dostave: {TypeDelivery}");
            Console.WriteLine($"Ime primatelja: {Name}");
            Console.WriteLine($"Adresa dostave: {Adress}");
            Console.WriteLine($"Datum dostave: {Date:d}");
        }
    }

      
}
