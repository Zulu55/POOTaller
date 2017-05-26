using System;
using System.Collections.Generic;

namespace POOTaller
{
    public class Sale
    {
        public Customer Customer { get; set; }

        public List<Product> Products { get; set; }

        public decimal Total()
        {
            decimal total = 0;
            foreach (var product in Products)
            {
                total += product.GetValue();
            }
            return total;
        }

        public override string ToString()
        {
            var products = string.Empty;
            foreach (var product in Products)
            {
                products += product;
            }

            return string.Format(@"*** SALE ***
Customer............: {0}
Date................: {1:yyyy/MM/dd H:mm}
{2}
                      ============
TOTAL...............: {3,12:C2}", 
Customer, DateTime.Now, products, Total());
        }
    }
}
