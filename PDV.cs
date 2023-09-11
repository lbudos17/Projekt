namespace Program 
{
    public class PDV
{

    public static double IzracunajPdv(Product storeProducts)
    {
        return storeProducts.Price  + (storeProducts.Price  * 0.25);
    }

    public static double IzracunajUkupniPdv(List<Product> storeProducts)
    {
        double ukupniPdv = 0;
        foreach (var storeproduct in storeProducts)
        {
            ukupniPdv += IzracunajPdv(storeproduct);
        }
        return ukupniPdv;
    }
}
}