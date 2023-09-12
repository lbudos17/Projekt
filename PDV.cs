namespace Program 
{
    public class PDV
{

    public static double CalculatePdv(Product storeProducts)
    {
        return storeProducts.Price  + (storeProducts.Price  * 0.25);
    }

    public static double CalculateTotalPdv(List<Product> storeProducts)
    {
        double totalPdv = 0;
        foreach (var storeproduct in storeProducts)
        {
            totalPdv += CalculatePdv(storeproduct);
        }
        return totalPdv;
    }
}
}