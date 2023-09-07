namespace Program {
    public class Dostava {
public class DostavaPostom: Dostava
{
    public string TipDostave { get; set;} 
    public string Adresa { get; set;}
    public double DatumDostave { get; set;}

    public DostavaPostom(string adresa, double DatumDostave)

    {
        this.TipDostave= "Dostava poštom";
        Adresa = adresa;
        DatumDostave = DatumDostave;
    }

    public void Isporuci()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}


public class DostavaKurirskomSluzbom : Dostava
{
    public string TipDostave { get; set; }  
    public string Adresa { get; set; }
    public double DatumDostave { get; set; }

    public DostavaKurirskomSluzbom(string adresa, double DatumDostave)
    {
        this.TipDostave= "Dostava kurirskom službom";
        this.Adresa = adresa;
        this.DatumDostave = DatumDostave;
    }

    public void Isporuci()
    {
        Console.WriteLine("Podaci o dostavi:");
        Console.WriteLine($"Tip dostave: {TipDostave}");
        Console.WriteLine($"Adresa: {Adresa}");
        Console.WriteLine($"Datum dostave: {DatumDostave:d}");
    }
}
    }
}