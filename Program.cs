Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] izvor = new string [3] { "biljna hrana", "hrana životinjskog podrijetla", "izlaganje suncu"};
 

Vitamin user = new Vitamin("Vitamin A", "retinol", "vid, imunitet, reproduktivno zdravlje", "noćno sljepilo, sklonost infekcijama", izvor[1], 800, true);

Console.WriteLine("Naziv: {0}", user.ime);
Console.WriteLine("Drugi naziv: {0}", user.drugo);
Console.WriteLine("Funkcije: {0}", user.funkcije);
Console.WriteLine("Nedostaci: {0}", user.nedostatak);
Console.WriteLine("Izvori: {0}", user.izvor);
Console.WriteLine("Preporučeni dnevni unos u mcg: {0}", user.unos);
Console.WriteLine("Vitamin topljiv u: {0}", user.topljivost ? "mastima" : "vodi" );





class Vitamin {
    public string ime;
    public string drugo; 
    public string funkcije;
    public string nedostatak;
    public string izvor;
    public int unos;
    public bool topljivost; //u mastima true, u vodi false

    public Vitamin(string ime, string drugo, string funkcije, string nedostatak, string izvor, int unos, bool topljivost) {
        this.ime = ime;
        this.drugo = drugo;
        this.funkcije = funkcije;
        this.nedostatak = nedostatak;
        this.izvor = izvor;
        this.unos = unos;
        this.topljivost = topljivost;
    
    }



}

