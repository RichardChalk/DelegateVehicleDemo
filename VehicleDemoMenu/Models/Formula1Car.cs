using VehicleDemoMenu.Interfaces;

namespace VehicleDemoMenu.Models
{
    public class Formula1Car : IVehicle
    {
        /// <summary>
        /// Skapar en klass som heter "Formula1Car" och implementerar
        /// IVehicle-gränssnittet
        /// </summary>
        public string Drive()
        {
            return "Racing a Formula 1 car!";
        }

        // Alternativt sätt att skriva metoden Drive med en lambda-uttryck:
        // Lambda-uttrycket gör metoden kortare och fungerar likadant
        // public string Drive() => "Driving a Formula 1 car!";
    }
}
