namespace Program {
    public class Product {
        public int Number { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        

        public Product ( int Number, string Name, double Price, int Quantity) 
        {
            this.Number = Number;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
