using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curtis_Inventory
{
    class Crackers : IShippable
    {
        private int _count;
        private string _name;
        private double _cost;
        public Crackers(string name, double cost, int count)
        {
            _name = name;
            _cost = cost;
            _count = count;
        }
        public string Product
        {
            get { return _name; }
            set { _name = value; }
        }
        public double ShipCost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public int InventoryCount(int number)
        {
            _count = _count + number;
            return _count;
        }
    }
}
