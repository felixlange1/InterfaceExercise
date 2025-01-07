using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    
    public bool IsCrossover { get; set; }
    public string Size { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberofWheels { get; set; }
    public int HorsePower { get; set; }


    public string Name { get; set; }
    public string Logo { get; set; }
    
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Make: {Name}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Number of Wheels: {NumberofWheels}");
        Console.WriteLine($"Horse Power: {HorsePower}");
        Console.WriteLine($"Size: {Size}");
        Console.WriteLine($"Crossover: {IsCrossover}");
        Console.WriteLine("------------------------");
    }
}