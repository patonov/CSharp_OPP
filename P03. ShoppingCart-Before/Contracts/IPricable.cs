using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before.Contracts
{
    public interface IPricable
    {

        decimal CalculatePrice(OrderItem item);
            

        bool IsMatch(OrderItem item);

    }
}
