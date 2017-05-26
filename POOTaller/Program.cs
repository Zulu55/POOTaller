using System;
using System.Collections.Generic;

namespace POOTaller
{
    class Program
    {
        static Sale sale;

        static void Main(string[] args)
        {
            InitializateSale();

            ConsoleKey opc;
            do
            {
                opc = Menu();
                switch (opc)
                {
                    case ConsoleKey.D1:
                        AssingCustomer();
                        break;
                    case ConsoleKey.D2:
                        AddProduct();
                        break;
                    case ConsoleKey.D3:
                        Pay();
                        break;
                }
            } while (opc != ConsoleKey.D0);
        }

        private static void InitializateSale()
        {
            sale = new Sale
            {
                Products = new List<Product>(),
            };
        }

        private static void Pay()
        {
            if (sale.Customer == null)
            {
                Console.WriteLine("\nERROR: You need to assing a custumer first.");
                return;
            }

            if (sale.Products.Count == 0)
            {
                Console.WriteLine("\nERROR: You need to add some product first.");
                return;
            }

            Console.WriteLine(sale);
            InitializateSale();
        }

        private static void AddProduct()
        {
            Console.Write("\nDescription.....................? ");
            var description = Console.ReadLine();
            Console.Write("Id..............................? ");
            var id = Console.ReadLine();
            Console.Write("Product type, [F]ixed [V]ariable? ");
            var type = Console.ReadKey().Key;
            if (type == ConsoleKey.F)
            {
                AddProductFixed(description, id);
            }
            else
            {
                AddProductVariable(description, id);
            }
        }

        private static void AddProductVariable(string description, string id)
        {
            Console.Write("\nMesumeasurement unit............? ");
            var mesumeasurementUnit = Console.ReadLine();
            Console.Write("Mesumeasurement price...........? ");
            var mesumeasurementPrice = Console.ReadLine();
            Console.Write("Quantity.....................}...? ");
            var quantity = Console.ReadLine();
            sale.Products.Add(new VariablePriceProduct
            {
                Description = description,
                Id = int.Parse(id),
                MesumeasurementUnit = mesumeasurementUnit,
                MesumeasurementUnitPrice = decimal.Parse(mesumeasurementPrice),
                Quantity = double.Parse(quantity),
            });
        }

        private static void AddProductFixed(string description, string id)
        {
            Console.Write("\nPrice...........................? ");
            var price = Console.ReadLine();
            sale.Products.Add(new FixPriceProduct
            {
                Description = description,
                Id = int.Parse(id),
                Price = decimal.Parse(price),
            });
        }

        private static void AssingCustomer()
        {
            Console.Write("\nCustomer Id..? ");
            var id = Console.ReadLine();
            Console.Write("Customer name? ");
            var name = Console.ReadLine();
            sale.Customer = new Customer
            {
                Id = int.Parse(id),
                Name = name,
            };
        }

        private static ConsoleKey Menu()
        {
            Console.WriteLine("\n*** MENU ***");
            Console.WriteLine("1. Assing customer");
            Console.WriteLine("2. Add product");
            Console.WriteLine("3. Pay");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice is: ");
            return Console.ReadKey().Key;
        }
    }
}