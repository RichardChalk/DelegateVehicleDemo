// Importerar gränssnittet IVehicle som definierar
// standardmetoder för alla fordon
using VehicleDemoMenu.Interfaces;

namespace VehicleDemoMenu.Models
{
    /// <summary>
    /// Skapar en klass som heter "Car" och implementerar
    /// IVehicle-gränssnittet
    /// </summary>
    public class Car : IVehicle
    {
        public string Drive()
        {
            return "Driving a car!";
        }

        // Alternativt sätt att skriva metoden Drive med en lambda-uttryck:
        // Lambda-uttrycket gör metoden kortare och fungerar likadant
        // public string Drive() => "Driving a car!";
    }
}
