namespace P03._ShoppingCart
{
    using System.Collections.Generic;
    using System.Linq;
    using P03._ShoppingCart_Before.Contracts;
    using P03._ShoppingCart_Before.Rules;

    public public class Cart
    {
        private readonly List<OrderItem> items;
        private readonly List<IPricable> promotions = new List<IPricable>()
        {
            new BlackFriday(),
            new HappyFriday(),
            new SpecialPromo()
        };

        public Cart()
        {
            this.items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return new List<OrderItem>(this.items); }
        }

        public string CustmerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            this.items.Add(orderItem);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;

            foreach (var item in this.items)
            {
                var promoRule = promotions.FirstOrDefault(p => p.IsMatch(item));

                if (promoRule == null)
                {
                    total += item.Price;
                }
                else
                {
                    total += promoRule.CalculatePrice(item);
                }
            }

            return total; 
        }
    }
}
