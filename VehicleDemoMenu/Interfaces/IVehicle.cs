namespace VehicleDemoMenu.Interfaces
{
    // Definierar ett gränssnitt som heter "IVehicle"
    // Gränssnitt används för att skapa en "mall" som
    // klasser kan implementera
    public interface IVehicle
    {
        // En metod som heter "Drive" som returnerar en sträng
        // Varje klass som implementerar IVehicle-gränssnittet behöver definiera 
        // hur Drive-metoden fungerar
        // (t.ex. köregenskaper för olika fordonstyper).
        string Drive();
    }
}
