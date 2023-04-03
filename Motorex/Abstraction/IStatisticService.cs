using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motorex.Abstraction
{
    public interface IStatisticService
    {
        int CountProducts();
        int CountClients();
        int CountOrders();
        decimal SumOrders();
    }
}
