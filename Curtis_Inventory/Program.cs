using System;
// Name: Micah Curtis
// Course: IT 112
// Notes:
// Behaviors Not Implemented: I couldn't pull any of the info from the interface
// or manipulate the array without the program crashing. (I couldn't get the calculations or the 
// list preview to work)
namespace Curtis_Inventory
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            bool yesNo = false;
            do
            {
                Console.Clear();
                DisplayMenu();
                Console.WriteLine("");
                int option = int.Parse(Console.ReadLine());
                Console.Clear();
                IShippable[] shippables = new IShippable[10];
                switch (option)
                {
                    case 1:
                        Bicycles bike = new Bicycles("Bicycle", 9.50, 1);
                        AddToList(bike, shippables);
                        bike.InventoryCount(1);
                        Console.WriteLine("1 Bicycle has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 2:
                        LawnMower lm = new LawnMower("Lawn Mower", 24, 1);
                        AddToList(lm, shippables);
                        lm.InventoryCount(1);
                        Console.WriteLine("1 Lawn Mower has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 3:
                        BaseballGloves glove = new BaseballGloves("Baseball Glove", 3.23, 1);
                        AddToList(glove, shippables);
                        glove.InventoryCount(1);
                        Console.WriteLine("1 Baseball Glove has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 4:
                        Crackers cracker = new Crackers("Crackers", .57, 1);
                        AddToList(cracker, shippables);
                        cracker.InventoryCount(1);
                        Console.WriteLine("1 Crackers has been added");
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 5:
                        int count = 0;
                        Console.WriteLine("Shipment Manifest:");
                        for (int i = 0; i <=1; i++)
                        {
                            count++;
                            ProcessInventory(shippables[i]);
                        }
                        Console.WriteLine("Press any key to return to the menu");
                        Console.ReadLine();
                        break;
                    case 6:
                        break;
                } 
            
            }while(yesNo==false);


        }
        static void DisplayMenu()
        {
            Console.WriteLine("Choose from the following options (Press the Corresponding Number Followed by Enter): ");
            Console.WriteLine("1. Add a Bicycle to the Shipment");
            Console.WriteLine("2. Add a Lawn Mower to the Shipment");
            Console.WriteLine("3. Add a Baseball Glove to the Shipment");
            Console.WriteLine("4. Add Crackers to the Shipment");
            Console.WriteLine("5. List Shipment Items");
            Console.WriteLine("6. Compute Shippine Charges");
        }
        static bool AddToList(IShippable item, IShippable[] shipList)
        {
            for (int i = 0; i < shipList.Length; i++)
            {
                if (shipList[i] == null)
                {
                    shipList[i] = item;
                    return true;
                }
                
            }
            return false;
        }
        static void ProcessInventory(IShippable item)
        {
            Console.WriteLine(item.Count + item.Product);
            
        }
    }
}
