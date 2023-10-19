using System;

class Product1
{
    //Attributes
    public string Name;
    public double Price;
    public int Quantity;

    //Paramterized Constructor
    public Product1(string name, double price, int quantity)
    {
        this.Name = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public double CalculateTotalCost()
    {
        return Price * Quantity;
    }
}

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product1[] product = new Product1[3];

            product[0] = new Product1("Laptop", 1000.00, 5);
            product[1] = new Product1("Mouse", 500.00, 10);
            product[2] = new Product1("Phone", 800.00, 5);

            double totalcost = 0.0;
            for (int i = 0; i < product.Length; i++)
            {
                totalcost += product[i].CalculateTotalCost();
            }

            Console.WriteLine("Total Cost of Products in Stock $ " + totalcost);
        }
    }
}
