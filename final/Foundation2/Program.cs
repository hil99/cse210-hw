using System;

class Program
{
    static void Main()
    {
        Order myOrder = new Order(101);
        Item item1 = new Item("Laptop", 1200.00);
        Item item2 = new Item("Mouse", 25.99);

        myOrder.AddItem(item1);
        myOrder.AddItem(item2);
        myOrder.DisplayOrderDetails();

        myOrder.RemoveItem(item1);
        myOrder.DisplayOrderDetails();
    }
}
