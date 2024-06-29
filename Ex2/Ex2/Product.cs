using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex2
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int AmountInStock { get; private set; }

        public Product()
        {
        }

        public Product(string name, double price, int amountInStock)
        {
            Name = name;
            Price = price;
            AmountInStock = amountInStock;
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

        public void ChangePrice(double newPrice)
        {
            Price = newPrice;
        }

        public void AddAmountInStock(int amountToAdd)
        {
            AmountInStock += amountToAdd;
        }

        public void RemoveAmountInStock(int amountToRemove)
        {
            AmountInStock -= amountToRemove;
        }

        public override string ToString()
        {
            return $"Product: {Name} - ${Price.ToString("F2", CultureInfo.InvariantCulture)} - {AmountInStock} un";
        }
    }
}