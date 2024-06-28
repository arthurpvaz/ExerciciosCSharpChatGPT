using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex2
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int AmountOnStock { get; private set; }

        public Product() 
        {
        }

        public Product(string name, double price, int amountOnStock)
        {
            Name = name;
            Price = price;
            AmountOnStock = amountOnStock;
        }

        public void ChangeName(string name)
        {
            Name = name;
        }

        public void ChangePrice(double price)
        {
            Price = price;
        }

        public void AddAmountOnStock(int amountToAdd)
        {
            AmountOnStock += amountToAdd;
        }

        public void RemoveAmountOnStock(int amountToRemove)
        {
            AmountOnStock -= amountToRemove;
        }

        public override string ToString()
        {
            return $"Product: {Name} - ${Price.ToString("F2", CultureInfo.InvariantCulture)} - {AmountOnStock} un";
        }
    }
}