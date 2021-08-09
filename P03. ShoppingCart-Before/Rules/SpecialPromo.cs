using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Rules
{
    using P03._ShoppingCart_Before.Contracts;

    public class SpecialPromo : IPricable
    {
        decimal CalculatePrice(OrderItem item)
        {
            decimal price = 0m;
            price += item.Quantity * .4m;
            decimal setsOfThree = item.Price / 3;
            price -= setsOfThree * .2m;

            return price;
        }

        bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }

    }
}
