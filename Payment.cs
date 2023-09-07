
namespace Program 
{
abstract class PaymentMethod 
{
    public abstract void Payment (double amount);

        
    }
 class CardPayment : PaymentMethod {
         public override void Payment(double amount) {
             Console.WriteLine($"Plaćen iznos od {amount:C} karticom.");
        }
     }

    class CashPayment : PaymentMethod {
        public override void Payment(double amount) {
             Console.WriteLine($"Plaćen iznos od {amount:C} u gotovini.");
        }
    }

     class CheckPayment : PaymentMethod {
         public override void Payment(double amount) {
             Console.WriteLine($"Plaćen iznos od {amount:C} čekom.");
        }
    }
}
