using VehicleDemoMenu.Delegates;
using VehicleDemoMenu.Factory;
using VehicleDemoMenu.Interfaces;
using VehicleDemoMenu.Models;

namespace VehicleDemoMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleDelegate vehicleDelegate = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välj ett fordon:");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Bus");
                Console.WriteLine("3. Formula 1 Car");
                Console.WriteLine("4. Avsluta");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        vehicleDelegate = VehicleFactory.CreateCar;
                        // vehicleDelegate = () => new Car();
                        break;
                    case "2":
                        vehicleDelegate = VehicleFactory.CreateBus;
                        // vehicleDelegate = () => new Bus();
                        break;
                    case "3":
                        vehicleDelegate = VehicleFactory.CreateFormula1Car;
                        // vehicleDelegate = () => new Formula1Car();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        continue;
                }

                IVehicle vehicle = vehicleDelegate();
                // Samma som raden ovanför                
                // IVehicle vehicle = vehicleDelegate.Invoke();
                
                Console.WriteLine(vehicle.Drive());
                
                Console.WriteLine("Tryck valfri tangent för att fortsätta");
                Console.ReadLine();
            }
        }
    }
}
