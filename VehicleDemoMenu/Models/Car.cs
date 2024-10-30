// Importerar gränssnittet IVehicle som definierar
// standardmetoder för alla fordon
using VehicleDemoMenu.Interfaces;

namespace VehicleDemoMenu.Models
{
    // Skapar en klass som heter "Car" och implementerar
    // IVehicle-gränssnittet
    public class Car : IVehicle
    {
        // Implementerar Drive-metoden från IVehicle-gränssnittet
        // Denna metod returnerar en textsträng som beskriver handlingen
        public string Drive()
        {
            return "Driving a car!";
        }

        // Alternativt sätt att skriva metoden Drive med en lambda-uttryck:
        // Lambda-uttrycket gör metoden kortare och fungerar likadant
        // public string Drive() => "Driving a car!";
    }
}
