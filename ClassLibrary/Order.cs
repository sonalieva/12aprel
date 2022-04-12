using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Order
    {
        public Order()
        {
            No++;
            _no = No;
                
        }
        static int _no;
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
