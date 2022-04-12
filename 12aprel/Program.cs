using System;
using ClassLibrary;

namespace _12aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.TotalAmount = 15;
            order1.ProductCount = 2;
            order1.CreatedAt = Convert.ToDateTime("2834.03.20");

            Order order2 = new Order();
            order1.TotalAmount = 28;
            order1.ProductCount = 1;
            order1.CreatedAt = Convert.ToDateTime("2943.04.22");


            Shop shop = new Shop();
            shop.AddOrder(order1);
            shop.AddOrder(order2);
            DateTime datetime = Convert.ToDateTime("2323.12.22");

            Console.WriteLine(shop.GetOrdersAvarage(datetime));
            Console.WriteLine(shop.GetOrdersAvarage());

            shop.RemoveOrderByNo(1);
            foreach(var item in shop.FilterOrderByPrice(10, 30))
            {
                Console.WriteLine($"Totalamaunt: {item.TotalAmount}");
            }

        }
    }
}
