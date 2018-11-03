using System;

namespace NET_Core_Training.Models
{
    public class Order
    {
        public int Id { get; private set; }
        public decimal Price { get; private set; }
        public decimal TaxRate { get; } = 0.23M;
        public decimal TotalPrice { get { return Price * (1+TaxRate); } }
        public bool IsPucharsed { get; private set; }

        public Order (int id, decimal price )
        {
            if(price<=0)
            {
                throw new Exception("Price must be greater than 0.");
            }
            this.Id=id;
            this.Price=price;
        }

        public void Pucharse()
        {
            if(IsPucharsed)
            {
                throw new Exception("Order was already pucharsed.");
            }
            IsPucharsed =true;
        }
    }
}