using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            var suv1 = new SUV()
            {
                HorsePower = 360,
                IsCrossover = false,
                Name = "BMW",
                Logo = "blue and white",
                Model = "X5",
                NumberofWheels = 4,
                Size = "Midsize",
                Year = 2023
                
            };

            var truck1 = new Truck()
            {
                HorsePower = 320,
                HasCrewCab = true,
                Logo = "blue and white",
                Name = "Ford",
                Model = "F150",
                NumberofWheels = 4,
                Weight = 4000,
                Year = 2023
            };

            var car1 = new Car()
            {
                HorsePower = 180,
                HasTrunk = true,
                IsCoupe = false,
                Logo = "gray",
                Name = "Toyota",
                Model = "Camry",
                NumberofWheels = 4,
                Year = 2018
            };
            
            car1.DisplayDetails();
            suv1.DisplayDetails();
            truck1.DisplayDetails();

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
