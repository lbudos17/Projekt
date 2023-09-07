

namespace Program {
    class Program {
        static List<Product> storeProducts = new List<Product>();
        static PaymentMethod selectedPaymentMethod;

        static void Main(string[] args) // main menu 
        
        {
            Store();

            while (true)
            {
                Console.WriteLine("***********************************");
                Console.WriteLine("Izbornik:");
                Console.WriteLine("***********************************");
                Console.WriteLine("1. Popis proizvoda");
                Console.WriteLine("2. Dodaj novi proizvod");
                Console.WriteLine("3. Kupi proizvod");
                Console.WriteLine("4. Izlaz iz aplikacije");
                Console.WriteLine("***********************************");
                Console.Write("Unesite svoj izbor: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ListProducts();
                            break;
                        case 2:
                            AddProduct();
                            break;
                        case 3:
                            BuyProduct();
                            break;
                        case 4:
                            Console.WriteLine("Izlazim iz programa.");
                            return;
                        default:
                            Console.WriteLine("Pogrešan izbor. Pokušajte ponovno.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Pogrešan unos. Unesite valjanu opciju.");
                }
            }
        }

        static void Store()
        {
            Product user = new Product ( 1, "Milk", 7, 15);
            Product user2 = new Product ( 2, "Eggs", 18, 20);
            Product user3 = new Product ( 3, "Bread", 6, 25);
            Product user4 = new Product ( 4, "Cocholate", 12, 10);
            Product user5 = new Product ( 5, "Lollypop", 1, 50);

            storeProducts.Add(user);
            storeProducts.Add(user2);
            storeProducts.Add(user3);
            storeProducts.Add(user4);
            storeProducts.Add(user5);
             
            
        }

        static void ListProducts() // lista proizvoda
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Proizvodi u trgovini:");
            Console.WriteLine("***********************************");
            Console.WriteLine("Broj\tIme proizvoda\t\tCijena\t\tKoličina");

            foreach (var product in storeProducts)
            {
                Console.WriteLine($"{product.Number}\t{product.Name}\t\t{product.Price}\t\t{product.Quantity}");
            }

            Console.WriteLine("***********************************");
            Console.WriteLine("Pritisnite Enter za nastavak.");
            Console.ReadLine();
        }

        static void AddProduct() // dodaj proizvode
        {
            Console.WriteLine("\n***********************************");
            Console.Write("Unesite ime proizvoda: ");
            string name = Console.ReadLine();

            Console.WriteLine("\n***********************************");
            Console.Write("Unesite cijenu novog proizvoda: ");
            if (double.TryParse(Console.ReadLine(), out double price))
            {
                Console.WriteLine("\n***********************************");
                Console.Write("Unesite količinu novog proizvoda: ");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    int number = storeProducts.Count + 1;
                    storeProducts.Add(new Product { Number = number, Name = name, Price = price, Quantity = quantity });
                    Console.WriteLine($"Proizvod '{name}' dodan je u trgovinu.");
                }
                else
                {
                    Console.WriteLine("Neodgovarajuća količina. Unesite valjani broj.");
                }
            }
            else
            {
                Console.WriteLine("Neodgovarajuća cijena. Unesite valjani broj.");
            }
        }

        static void BuyProduct() // kupovina proizvoda
        {
            Console.WriteLine("\n***********************************");
            Console.WriteLine("Kupovina proizvoda:");
            ListProducts();

            Console.WriteLine("***********************************");
            Console.Write("Unesite broj proizvoda koji želite kupiti (0 za nazad): ");
            if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0 && Number <= storeProducts.Count)
            {
                Product selectedProduct = storeProducts[Number - 1];

                Console.WriteLine("***********************************");
                Console.Write($"Unesite količinu proizvoda '{selectedProduct.Name}' koju želite kupiti (0 za nazad): ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                {
                    if (quantity <= selectedProduct.Quantity)
                    {
                        Console.WriteLine("\n***********************************");
                        Console.WriteLine($"Ukupni iznos bez PDV-a za {quantity} '{selectedProduct.Name}' je: {selectedProduct.Price * quantity}");

                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Odaberite način plaćanja:");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("1. Kreditna kartica");
                        Console.WriteLine("2. Gotovina");
                        Console.WriteLine("3. Ček");
                        Console.WriteLine("***********************************");
                        Console.Write("Unesite svoj izbor plaćanja: ");

                        if (int.TryParse(Console.ReadLine(), out int paymentChoice))
                        {
                            switch (paymentChoice)
                            {
                                case 1:
                                    selectedPaymentMethod = new CardPayment();
                                    break;
                                case 2:
                                    selectedPaymentMethod = new CashPayment();
                                    break;
                                case 3:
                                    selectedPaymentMethod = new CheckPayment();
                                    break;
                                default:
                                    Console.WriteLine("Nevažeći izbor plaćanja. Plaćanje otkazano.");
                                    return;
                            }
                            Console.WriteLine("***********************************");
                            // kupili ste proizvod xyz
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("<<<<< Račun >>>>>");
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine($"Ime proizvoda: '{selectedProduct.Name}'");
                            Console.WriteLine("-----------------------------------");
                            selectedPaymentMethod(selectedProduct.Price * quantity);
                    
                            selectedProduct.Quantity -= quantity;
                            Console.WriteLine($"Uspješno ste kupili {quantity} '{selectedProduct.Name}'.");
                        }
                        else
                        {
                            Console.WriteLine("Nevažeći izbor plaćanja. Plaćanje otkazano.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nedovoljna količina'{selectedProduct.Name}' u trgovini.");
                    }
                }
                else
                {
                    Console.WriteLine("Nevažeća količina. Unesite važeći broj.");
                }
            }
            else if (Number == 0)
            {
                // odlazak nazad u main menu
            }
            else
            {
                Console.WriteLine("Nevažeći broj proizvoda. Unesite važeći broj.");
            }
        }

       
    }
}

















