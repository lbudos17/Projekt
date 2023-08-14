Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] izvor = new string [3] { "biljna hrana", "hrana životinjskog podrijetla", "izlaganje suncu"};
 

Vitamin user = new Vitamin("Vitamin A", "retinol", "vid, imunitet, reproduktivno zdravlje", "noćno sljepilo, sklonost infekcijama", izvor[1], 800, true);
Vitamin user2 = new Vitamin("Vitamin C", "askorbinska kiselina", "antioksidacijsko djelovanje, obnova vitamina E, potpora imunološkom sustavu", "skorbut", izvor[0], 80, false);
Vitamin user3 = new Vitamin("Vitamin D", "kalciferol", "regulacija krvnog tlaka, imunološki odgovor", "rahitis, psorijaza, multipla skleroza", izvor[2], 5, true);
Vitamin user4 = new Vitamin("Vitamin E", "tokoferol", "održavanje zdravlja kože, krvožilnog i neurološkog sustava, sprječavanje oksidativnog stresa", "gubitak mišićne mase, anemija, pogoršan vid", izvor[0], 12, true);
Vitamin user5 = new Vitamin("Vitamin H", "biotin", "proizvodnja energije, regulacija gena i stanična signalizacija", "gubitak kose, konjuktivitis, depresija, halucinacije", izvor[1], 50, false);

Console.WriteLine("**********************************************************************");
Console.WriteLine("Naziv: {0}", user.ime);
Console.WriteLine("Drugi naziv: {0}", user.drugo);
Console.WriteLine("Funkcije: {0}", user.funkcije);
Console.WriteLine("Nedostatak u organizmu izaziva: {0}", user.nedostatak);
Console.WriteLine("Glavni izvor: {0}", user.izvor);
Console.WriteLine("Preporučeni dnevni unos u mcg: {0}", user.unos);
Console.WriteLine("Vitamin topljiv u: {0}", user.topljivost ? "mastima" : "vodi" );

Console.WriteLine("**********************************************************************");
Console.WriteLine("Naziv: {0}", user2.ime);
Console.WriteLine("Drugi naziv: {0}", user2.drugo);
Console.WriteLine("Funkcije: {0}", user2.funkcije);
Console.WriteLine("Nedostatak u organizmu izaziva: {0}", user2.nedostatak);
Console.WriteLine("Glavni izvor: {0}", user2.izvor);
Console.WriteLine("Preporučeni dnevni unos u mg: {0}", user2.unos);
Console.WriteLine("Vitamin topljiv u: {0}", user2.topljivost ? "mastima" : "vodi" );

Console.WriteLine("**********************************************************************");

Console.WriteLine("**********************************************************************");
Console.WriteLine("Naziv: {0}", user3.ime);
Console.WriteLine("Drugi naziv: {0}", user3.drugo);
Console.WriteLine("Funkcije: {0}", user3.funkcije);
Console.WriteLine("Nedostatak u organizmu izaziva: {0}", user3.nedostatak);
Console.WriteLine("Glavni izvor: {0}", user3.izvor);
Console.WriteLine("Preporučeni dnevni unos u mcg: {0}", user3.unos);
Console.WriteLine("Vitamin topljiv u: {0}", user3.topljivost ? "mastima" : "vodi" );

Console.WriteLine("**********************************************************************");
Console.WriteLine("Naziv: {0}", user4.ime);
Console.WriteLine("Drugi naziv: {0}", user4.drugo);
Console.WriteLine("Funkcije: {0}", user4.funkcije);
Console.WriteLine("Nedostatak u organizmu izaziva: {0}", user4.nedostatak);
Console.WriteLine("Glavni izvor: {0}", user4.izvor);
Console.WriteLine("Preporučeni dnevni unos u mg: {0}", user4.unos);
Console.WriteLine("Vitamin topljiv u: {0}", user4.topljivost ? "mastima" : "vodi" );

Console.WriteLine("**********************************************************************");

Console.WriteLine("Naziv: {0}", user5.ime);
Console.WriteLine("Drugi naziv: {0}", user5.drugo);
Console.WriteLine("Funkcije: {0}", user5.funkcije);
Console.WriteLine("Nedostatak u organizmu izaziva: {0}", user5.nedostatak);
Console.WriteLine("Glavni izvor: {0}", user5.izvor);
Console.WriteLine("Preporučeni dnevni unos u mcg: {0}", user5.unos);
Console.WriteLine("Vitamin topljiv u: {0}", user5.topljivost ? "mastima" : "vodi" );

Console.WriteLine("**********************************************************************");






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

