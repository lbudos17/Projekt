
namespace Program 
{
abstract class PaymentMethod 
{
    public abstract string Naziv {get;}

        
    }
class CardPayment : PaymentMethod 
{
    public override string Naziv {get; } = "Placanje karticom"; 
}
class CashPayment : PaymentMethod 
{
    public override string Naziv {get;} = "Placanje gotovinom";
}
class CheckPayment : PaymentMethod 
{
    public override string Naziv {get;} = "Placanje čekovima";
}
}
