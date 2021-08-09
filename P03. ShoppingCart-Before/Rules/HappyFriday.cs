using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Rules
{
    using P03._ShoppingCart_Before.Contracts;

    public class HappyFriday : IPricable
    {
        decimal CalculatePrice(OrderItem item)
        {
            return item.Price += item.Price / 2;
        }

        bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("HappyFriday");
        }

    }
}
