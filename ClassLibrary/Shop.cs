using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Shop
    {
        public List<Order> Orders = new List<Order>();
        public void AddOrder(Order orders)
        {
            Orders.Add(orders);
        }
        public int GetOrdersAvarage()
        {
            int sum = 0;
            int count = 0;
            int avg = 0;
            foreach(var item in Orders)
            {
                sum += item.TotalAmount;
                count++;
                avg = sum / count;

            }
            return avg;
        }
        public int GetOrdersAvarage(DateTime dateTime)
        {
            int sum = 0;
            int count = 0;
            int avg = 0;
            foreach(var item in Orders)
            {
                if(dateTime < item.CreatedAt)
                {
                    sum += item.TotalAmount;
                    count++;
                    avg = sum / count;
                }
               
            }
            return avg;

        }
        
        public void RemoveOrderByNo(int no)
        {
            var ord =Orders.Find(x => x.No == no);
            Orders.Remove(ord);


        }
        public List<Order> FilterOrderByPrice(int min, int max)
        {
            return Orders.FindAll(x => x.TotalAmount > min && x.TotalAmount < max);
        }
            

    }
}
