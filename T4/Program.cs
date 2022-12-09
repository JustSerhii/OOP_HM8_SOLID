using System;

/* порушено Interface Segregation Principle */

interface IItem
{
    void ApplyDiscount(string discount);
    void ApplyPromocode(string promocode);
    void SetPrice(double price);
}


interface IFeature
{
    void SetColor(byte color);
    void SetSize(byte size);
}

class Book : IItem
{
    private double price;
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine("The book's discount is: " + discount);
    }

    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine("The book's promocode: " + promocode);
    }
}

class Overgarment : IFeature, IItem
{
    private double price;
    private byte color;
    private byte size;
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void SetColor(byte color)
    {
        this.color = color;
    }
    public void SetSize(byte size)
    {
        this.size = size;
    }
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine("Overgarment's discount: " + discount);
    }
    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine("Overgarment's promocode is: " + promocode);
    }

}

class Program
{
    static void Main(string[] args)
    {

        Console.ReadKey();
    }
}
