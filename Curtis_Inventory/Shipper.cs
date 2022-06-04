using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Inventory
{
    class Shipper 
    {
        private double _totalCost;
        public Shipper()
        {
        }

        public void Add(IShippable shippable)
        {
            _totalCost = Math.Round(_totalCost + shippable.ShipCost, 2);
        }

    }
    
    
}
