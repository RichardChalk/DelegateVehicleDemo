// Importerar gränssnitten och modellerna som används i detta projekt
using VehicleDemoMenu.Interfaces;
using VehicleDemoMenu.Models;

namespace VehicleDemoMenu.Factory
{
    // En statisk klass som heter "VehicleFactory"
    // används för att skapa olika fordonstyper
    public static class VehicleFactory
    {
        // Skapar en bil genom att returnera ett nytt Car-objekt
        // som implementerar IVehicle-gränssnittet
        public static IVehicle CreateCar()
        {
            return new Car();
        }

        // Skapar en buss genom att returnera ett nytt Bus-objekt
        // som implementerar IVehicle-gränssnittet
        public static IVehicle CreateBus()
        {
            return new Bus();
        }

        // Skapar en Formel 1-bil genom att returnera ett nytt
        // Formula1Car-objekt som implementerar
        // IVehicle-gränssnittet
        public static IVehicle CreateFormula1Car()
        {
            return new Formula1Car();
        }
    }
}
