using System;
using NET_Core_Training.Models;

namespace NET_Core_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("mateusz@majer.pl","123456789");
            user.IncreaseFunds(123);
            user.Activate();
            Order order =new Order(1,100);
            user.PurchaseOrder(order);
            Console.WriteLine(user.Email+" "+user.CreatedAt+" "+user.Founds);
        }
    }
}
