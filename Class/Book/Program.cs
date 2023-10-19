using System;

class Book1
{

    //Attributes
    public string Tittle;
    public string Author;
    public double Price;

    //parameterized Constructor
    public Book1(string tittle, string author, double price)
    {
        this.Tittle = tittle;
        this.Author = author;
        this.Price = price;
    }

    //Method
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Details: ");
        Console.WriteLine("Tittle: "+ Tittle);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: $" + Price);
    }
}
namespace Book
{
     class Program
    {
        static void Main(string[] args)
        {
            Book1 B1 = new Book1("Harry Potter", "J.K Rowling", 250);
            B1.DisplayBookDetails();
        }
    }
}
