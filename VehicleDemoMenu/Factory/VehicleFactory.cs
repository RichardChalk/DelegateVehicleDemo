// Importerar gränssnitten och modellerna som används i detta projekt
using VehicleDemoMenu.Interfaces;
using VehicleDemoMenu.Models;

namespace VehicleDemoMenu.Factory
{
    /// <summary>
    /// En statisk Factory klass som heter "VehicleFactory"
    /// används för att skapa olika fordonstyper
    /// </summary>
    public static class VehicleFactory
    {
        /// <summary>
        /// Skapar en bil genom att returnera ett nytt Car-objekt
        /// som implementerar IVehicle-gränssnittet
        /// </summary>
        /// <returns>IVehicle</returns>
        public static IVehicle CreateCar()
        {
            return new Car();
        }

        /// <summary>
        /// Skapar en bil genom att returnera ett nytt Bus-objekt
        /// som implementerar IVehicle-gränssnittet
        /// </summary>
        /// <returns>IVehicle</returns>
        public static IVehicle CreateBus()
        {
            return new Bus();
        }

        /// <summary>
        /// Skapar en bil genom att returnera ett nytt Formel 1 Bil-objekt
        /// som implementerar IVehicle-gränssnittet
        /// </summary>
        /// <returns>IVehicle</returns>
        public static IVehicle CreateFormula1Car()
        {
            return new Formula1Car();
        }
    }
}
