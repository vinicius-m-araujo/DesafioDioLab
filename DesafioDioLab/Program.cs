using DesafioDioLab.Entities;

namespace DesafioDioLab;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Parking");
        Console.WriteLine("enter the initial price and price per hour");
        string[] input = Console.ReadLine().Split(' ');
        decimal initialPrice = decimal.Parse(input[0]);
        decimal pricePerHour = decimal.Parse(input[1]);
        var parking = new Parkings(pricePerHour, initialPrice);
        parking.Menu();
    }
}