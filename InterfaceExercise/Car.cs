namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    /* Create 2 members that are specific to each class
     * Example for Car: public bool HasTrunk { get; set; }
     * Example for SUV: public int NumberOfSeats { get; set; }
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     */
    public bool HasTrunk { get; set; }
    public bool IsCoupe { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int NumberofWheels { get; set; }
    public int HorsePower { get; set; }
    public string Name { get; set; }
    public string Logo { get; set; }
}