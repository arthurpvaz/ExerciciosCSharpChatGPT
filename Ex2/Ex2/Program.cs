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
                Console.WriteLine("1) Register a product");
                Console.WriteLine("2) Add amount of a product");
                Console.WriteLine("3) Remove amount of a product");
                Console.WriteLine("4) Change name of a product");
                Console.WriteLine("5) Change price of a product");
                Console.WriteLine("6) Calculate amount in stock");
                Console.WriteLine("7) Show products in Stock");
                Console.WriteLine("8) Leave");

                // input option
                Console.WriteLine();
                Console.Write("Option: ");
                int option = int.Parse(Console.ReadLine());

                // option validation
                if (option == 1)
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
                        int amountInStock = int.Parse(Console.ReadLine());

                        stock.Add(new Product(name, price, amountInStock));
                    }
                }
                else if (option == 2)
                {
                    // change amount product
                    Console.WriteLine("----- Add amount -----");
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    bool altered = false;

                    foreach (Product product in stock)
                    {
                        if (product.Name == name)
                        {
                            Console.WriteLine($"Actual amount: {product.AmountInStock} un");
                            Console.Write($"Amount to add: ");
                            int amountToAdd = int.Parse(Console.ReadLine());

                            product.AddAmountInStock(amountToAdd);

                            altered = true;
                        }
                    }

                    if (!altered)
                    {
                        Console.WriteLine("Product is not registered!");
                    }
                }
                else if (option == 3)
                {
                    Console.WriteLine("----- Remove amount -----");
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    bool altered = false;

                    foreach (Product product in stock)
                    {
                        if (product.Name == name)
                        {
                            Console.WriteLine($"Actual amount: {product.AmountInStock} un");
                            Console.Write("Amount to remove: ");
                            int amountToRemove = int.Parse(Console.ReadLine());

                            product.RemoveAmountInStock(amountToRemove);

                            altered = true;
                        }
                    }

                    if (!altered)
                    {
                        Console.WriteLine("Product is not registered!");
                    }
                }
                else if (option == 4)
                {
                    Console.WriteLine("----- Name change -----");
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    bool altered = false;

                    foreach (Product product in stock)
                    {
                        if (product.Name == name)
                        {
                            Console.WriteLine($"Actual name: {product.Name}");
                            Console.Write("New name: ");
                            string newName = Console.ReadLine();

                            product.ChangeName(newName);

                            altered = true;
                        }
                    }

                    if (!altered)
                    {
                        Console.WriteLine("Product is not registered!");
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("----- Price change -----");
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    bool altered = false;

                    foreach (Product product in stock)
                    {

                        if (product.Name == name)
                        {
                            Console.WriteLine($"Actual price: ${product.Price}");
                            Console.Write("New price: $");
                            double newPrice = double.Parse(Console.ReadLine());

                            product.ChangePrice(newPrice);

                            altered = true;
                        }
                    }

                    if (!altered)
                    {
                        Console.WriteLine("Product is not registered!");
                    }
                }
                else if (option == 6)
                {
                    Console.WriteLine("----- Amount in stock -----");
                    Console.Write("Product name: ");
                    string name = Console.ReadLine();

                    bool altered = false;

                    foreach (Product product in stock)
                    {
                        if (product.Name == name)
                        {
                            Console.WriteLine($"Amount in stock: {product.AmountInStock} un");

                            altered = true;
                        }
                        
                    }

                    if (!altered)
                    {
                        Console.WriteLine("Product is not registered!");
                    }
                }
                else if (option == 7)
                {
                    Console.WriteLine("Products in stock");

                    foreach (Product product in stock)
                    {
                        Console.WriteLine(product);
                    }
                
                }
                else if (option == 8)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }

                Console.WriteLine();
            }
        }

        static bool productAlreadyExists(string productName, List<Product> stock)
        {
            return (stock.Find(product => product.Name == productName) != null) ? true : false;
        }
    }
}