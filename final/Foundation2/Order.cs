using System;
using System.Collections.Generic;

public class Order
{
    // Attributes
    private int orderId;
    private List<Item> items;
    private double totalAmount;

    // Constructor
    public Order(int orderId)
    {
        this.orderId = orderId;
        this.items = new List<Item>();
        this.totalAmount = 0.0;
    }

    // Methods
    public void AddItem(Item item)
    {
        items.Add(item);
        totalAmount += item.GetPrice();
        Console.WriteLine($"{item.GetName()} added to the order.");
    }

    public void RemoveItem(Item item)
    {
        if (items.Remove(item))
        {
            totalAmount -= item.GetPrice();
            Console.WriteLine($"{item.GetName()} removed from the order.");
        }
        else
        {
            Console.WriteLine("Item not found in the order.");
        }
    }

    public double GetTotalAmount()
    {
        return totalAmount;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine($"Order ID: {orderId}");
        Console.WriteLine("Items in order:");
        foreach (var item in items)
        {
            Console.WriteLine($"- {item.GetName()} (${item.GetPrice()})");
        }
        Console.WriteLine($"Total Amount: ${totalAmount:F2}");
    }
}
