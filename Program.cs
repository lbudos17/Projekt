


namespace Program {
    class Program {
        static List<Product> storeProducts = new List<Product>();
        Product storeProduct = new Product ();
        static PaymentMethod ChoosePaymentMethod;

        static void Main(string[] args) 
        
        {
            Store();

            while (true)
            {
            
                Console.WriteLine("Izbornik:");
                Console.WriteLine("***********************************");
                Console.WriteLine("1. Popis proizvoda");
                Console.WriteLine("2. Kupi proizvod");
                Console.WriteLine("3. Dodaj novi proizvod");
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
                            BuyProduct();
                            break;
                        case 3:
                            AddNewProduct();
                            break;
                        case 4:
                            Console.WriteLine("Izlaz");
                            return;
                        default:
                            Console.WriteLine("Neadekvatan unos. Pokušajte ponovno.");
                            break;

                            
                    }
                }
                else
                {
                    Console.WriteLine("Neadekvatan unos. Pokušajte ponovno.");
                }
            }
        }

        static void Store()
        {
            Product user = new Product ( 1, "Mlijeko", 1.65, 15);
            Product user2 = new Product ( 2, "Jaja", 1.80, 20);
            Product user3 = new Product ( 3, "Kruh", 1.50, 25);
            Product user4 = new Product ( 4, "Čokolada", 2, 10);
            Product user5 = new Product ( 5, "Sir", 3.50, 50);

            storeProducts.Add(user);
            storeProducts.Add(user2);
            storeProducts.Add(user3);
            storeProducts.Add(user4);
            storeProducts.Add(user5);
             
            
        }

        static void ListProducts() // lista proizvoda
        {
            
            Console.WriteLine("Proizvodi u trgovini:");
            
            Console.WriteLine("Broj\tIme proizvoda\t\tCijena\t\tKoličina");

            foreach (var product in storeProducts)
            {
                Console.WriteLine($"{product.Number}\t{product.Name}\t\t{product.Price}\t\t{product.Quantity}");
            }

            Console.WriteLine("***********************************");
            Console.WriteLine("Pritisnite Enter za nastavak.");
            Console.ReadLine();
        }

        static void AddNewProduct() // dodaj proizvode
        {
            Console.WriteLine("\n***********************************");
            Console.Write("Unesite ime novog proizvoda: ");
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
                    Console.WriteLine("Neodgovarajuća količina. Unesite valjanu količinu.");
                }
            }
            else
            {
                Console.WriteLine("Neodgovarajuća cijena. Unesite valjanu cijenu.");
            }
        }

        static void BuyProduct() // kupovina proizvoda
        {
            Console.WriteLine("\n***********************************");
            Console.WriteLine("Kupovina proizvoda:");
            ListProducts();

            Console.WriteLine("***********************************");
            Console.Write("Unesite broj proizvoda koji želite kupiti: ");
            if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0 && Number <= storeProducts.Count)
            {
                Product selectedProduct = storeProducts[Number - 1];

                Console.WriteLine("***********************************");
                Console.Write($"Unesite količinu proizvoda '{selectedProduct.Name}' koju želite kupiti: ");
                if (int.TryParse(Console.ReadLine(), out int quantity) && quantity >= 0)
                {
                    if (quantity <= selectedProduct.Quantity)
                    {
                        Console.WriteLine("\n***********************************");
                        Console.WriteLine($"Ukupni iznos bez PDV-a za {quantity} '{selectedProduct.Name}' je: {selectedProduct.Price * quantity}");

                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Načini plaćanja:");
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("1. Kreditna kartica");
                        Console.WriteLine("2. Gotovina");
                        Console.WriteLine("3. Ček");
                        Console.WriteLine("***********************************");
                        Console.Write("Unesite broj željenog načina plaćanja: ");

                        if (int.TryParse(Console.ReadLine(), out int paymentMenu))
                        {
                            switch (paymentMenu)
                            {
                                case 1:
                                    ChoosePaymentMethod = new CardPayment();
                                    break;
                                case 2:
                                    ChoosePaymentMethod = new CashPayment();
                                    break;
                                case 3:
                                    ChoosePaymentMethod = new CheckPayment();
                                    break;
                                default:
                                    Console.WriteLine("Nevažeći odabir plaćanja.");
                                    return;
                            }
                            
                    
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

















