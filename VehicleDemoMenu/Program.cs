using System;
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
            // Option #1 (nullable)
            VehicleDelegate? vehicleDelegate = null;
            
            // Option #2 (inte nullable)
            // ... då måste man välja en start typ... tex. Car
            // VehicleDelegate vehicleDelegate = () => new Car();

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
                        // new Car() är inte en metod!
                        // ...utan ett uttryck som skapar en instans av Car.
                        // Men i C# kan en lambda användas för att definiera ett
                        // uttryck som genererar en instans, och det betraktas
                        // som en metoddefinition i detta sammanhang.

                        // Option #1 (Lamnda)
                        // vehicleDelegate = () => new Car();

                        // Option #2 (Factory)
                        // Anledningen till att man inte behöver parenteser()
                        // på CreateCar när du tilldelar den till vehicleDelegate
                        // är att du refererar till själva metoden som en delegat,
                        // inte anropar den direkt!
                        vehicleDelegate = VehicleFactory.CreateCar;
                        break;
                    case "2":
                        // vehicleDelegate = () => new Bus();
                        vehicleDelegate = VehicleFactory.CreateBus;
                        break;
                    case "3":
                        // vehicleDelegate = () => new Formula1Car();
                        vehicleDelegate = VehicleFactory.CreateFormula1Car;
                        break;
                    case "4":
                        return;
                    // Vad händer om man kommentera bort denna default?
                    // Man får salladsland på denna rad!
                    // IVehicle vehicle = vehicleDelegate();
                    // Varför?
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        continue;
                }

                // Anropar vehicleDelegate för att skapa ett nytt IVehicle-objekt
                // och tilldelar det till variabeln 'vehicle'.
                // Detta använder delegaten för att dynamiskt skapa en instans
                // av fordonstypen som är bunden till vehicleDelegate.
                IVehicle vehicle = vehicleDelegate();

                // Samma som raden ovanför                
                // ...är ett alternativt sätt att anropa delegaten direkt.
                // IVehicle vehicle = vehicleDelegate.Invoke();

                // Anropar Drive-metoden på vehicle-objektet och skriver ut
                // resultatet i konsolen.
                // Detta kör den specifika Drive-implementeringen för den aktuella
                // fordonstypen (t.ex. "Driving a car!" för en bil).
                Console.WriteLine(vehicle.Drive());

                Console.WriteLine("Tryck valfri tangent för att fortsätta");
                Console.ReadLine();
            }
        }
    }
}
