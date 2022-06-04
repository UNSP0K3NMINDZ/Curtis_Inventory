using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Inventory
{
    interface IShippable
    {
        double ShipCost { get; set; }
        string Product { get; set; }
        int Count { get; set; }

        int InventoryCount(int count);
    }
}
