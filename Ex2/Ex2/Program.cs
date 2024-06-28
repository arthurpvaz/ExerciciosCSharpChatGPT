using System;
using System.Globalization;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> stock = new List<Product>();

            while (true)
            {
                // menu option
                Console.WriteLine("----- Stock Control Menu -----");
                Console.WriteLine("Sections:");
                Console.WriteLine("1) Product register");
                Console.WriteLine("2) Stock management");
                Console.WriteLine("3) Leave");

                // input option
                Console.WriteLine();
                Console.Write("Option: ");
                int option = int.Parse(Console.ReadLine());

                // option validation
                if (option != 1 || option != 2 || option != 3)
                {
                    Console.WriteLine("Invalid option!");
                }
                else if (option == 1)
                {
                    // internal menu option
                    Console.WriteLine("----- Product Menu -----");
                    Console.WriteLine("1) Register a product");
                    Console.WriteLine("2) Add amount of a product");
                    Console.WriteLine("3) Remove amount of a product");
                    Console.WriteLine("4) Change name of a product");
                    Console.WriteLine("5) Change price of a product");
                    Console.WriteLine("6) Calculate amount on stock");

                    Console.WriteLine();
                    Console.Write("Option: ");
                    int internalOption = int.Parse(Console.ReadLine());

                    // internal option validation
                    if (internalOption != 1 || internalOption != 2 || internalOption != 3 || internalOption != 4 || internalOption != 5 || internalOption != 6)
                    {
                        Console.WriteLine("Invalid option!");
                    }
                    else if (internalOption == 1)
                    {
                        // product register
                        Console.WriteLine("----- Product Register -----");
                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        if (productAlreadyExists(name, stock))
                        {
                            Console.WriteLine("Product with this name already exists!");
                        }
                        else
                        {
                            Console.Write("Price: $");
                            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                            Console.Write("Amount in stock: ");
                            int amountOnStock = int.Parse(Console.ReadLine());

                            stock.Add(new Product(name, price, amountOnStock));
                        }
                    }
                    else if (internalOption == 2)
                    {
                        // change amount product
                        Console.WriteLine("----- Price change -----");
                        Console.Write("Product name: ");
                        string name = Console.ReadLine();

                        foreach (Product product in stock)
                        {
                            if (product.Name == name)
                            {
                                Console.WriteLine($"Actual price: ${product.Price}");
                                Console.Write($"New price: $");
                                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                                product.ChangePrice(price);
                            }
                            else
                            {
                                Console.WriteLine("Product is not registered!");
                            }
                        }
                    }
                }
            }
        }

        static bool productAlreadyExists(string productName, List<Product> stock)
        {
            return (stock.Find(product => product.Name == productName) != null) ? true : false;
        }
    }
}