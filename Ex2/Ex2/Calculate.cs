using System;
using System.Collections.Generic;

namespace Ex2
{
    static class Calculate
    {
        public static int AmountProductCreated(List<Product> products)
        {
            int count = 0;

            foreach (Product product in products)
            {
                count += product.AmountOnStock;
            }

            return count;
        }

        public static double TotalValueInStock(List<Product> stock)
        {
            double totalValue = 0;

            foreach (Product product in stock)
            {
                totalValue += (product.Price) * product.AmountOnStock;
            }

            return totalValue;
        }
    }
}
