namespace DesafioDioLab.Entities;

public class Parkings
{
    private decimal pricePerHour { get; set; }
    private decimal initialPrice { get; set; }
    
    private List<string> parkings { get; set; } = new List<string>();

    public Parkings(decimal PricePerHour, decimal InitialPrice)
    {
        pricePerHour = PricePerHour;
        initialPrice = InitialPrice;
    }

    public void AddVehicle()
    {
        Console.WriteLine("enter the plate of the parking");
        string plate = Console.ReadLine().ToUpper();
        if (plate == null)
        {
            Console.WriteLine("plate is empty");
            AddVehicle();
        }
        Console.WriteLine($"add vehicle {plate}");

        parkings.Add(plate);
        Console.ReadKey();
        Menu();
    }
    
    public void RemoveVehicle()
    {
        Console.WriteLine("enter the plate of the parking for remove");
        string plate = Console.ReadLine().ToUpper();
        Console.WriteLine("enter the time in the parking");
        int time = int.Parse(Console.ReadLine());
        
        if (plate == null || time == 0)
        {
            Console.WriteLine("plate is empty or time is invalid");
            RemoveVehicle();
        }

        if (parkings.Contains(plate))
        {
            var price = initialPrice + pricePerHour * time;
            parkings.Remove(plate);
            Console.WriteLine($"remove vehicle {plate} and price {price}");
            
        }
        Console.WriteLine($"remove vehicle {plate}");
        Console.ReadKey();
        Menu();
    }

    public void ListVehicles()
    {
        parkings.ForEach(Console.WriteLine);
        Console.ReadKey();
        Menu();

    }

    public void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Register a new vehicle");
            Console.WriteLine("2 - Remove a vehicle");
            Console.WriteLine("3 - List a vehicle");
            Console.WriteLine("4 - Exit");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    AddVehicle();
                    break;
                case "2":
                    RemoveVehicle();
                    break;
                case "3":
                    ListVehicles();
                    break;
                case "4":
                    return;
            }
        }
    }
}