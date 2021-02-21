using System;


namespace ConsoleApp1
{


    public class WarehouseOperation
    {
        public int addItem(int qty1, int qty2)
        {
            return qty1 + qty2;
        }

        public double removeItem(int qty1, int qty2)
        {

            int result = qty1 - qty2;


            if (result < 0)
            {
                Console.WriteLine("Error, not enough items stored to remove quantity asked");
            }
           
            return qty1 - qty2;
        }
        public double valueItem(int qtyItem, double pricePerItem)
        {
            return qtyItem * pricePerItem;
        }


        public int QtyMinMaxStored(int min, int max, int currentQuantity)
        {

            if (currentQuantity < min)
            {
                int qtyToOrder = min - currentQuantity
                Console.WriteLine("Critical minimum security level reached, please reorder at least" + qtyToOrder + " items");
            }
            else if(currentQuantity > min)
            {
                int qtyToRemove = currentQuantity - max
                Console.WriteLine("Critical maximum stored level reached, please remove at least" + qtyToRemove + " items");
            }



        }


    }


}