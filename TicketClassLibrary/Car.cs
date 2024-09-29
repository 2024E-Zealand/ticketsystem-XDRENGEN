namespace TicketClassLibrary
{
    /// <summary>
    /// Beskriver en bil med en licenseplate og date.
    /// </summary>
    public class Car : Vehicle
    {
        //Metoder

        /// <summary>
        /// Returnerer bilens faste pris.
        /// </summary>
        /// <returns>Den faste pris på 240.</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returnerer typen af bil.
        /// </summary>
        /// <returns>Strengen "Car"</returns>
        public override string VehicleType()
        {
            return "Car";
        }




        // Konstruktør

        /// <summary>
        /// Initialiserer en ny instans af Car-klassen.
        /// </summary>
        /// <param name="licenseplate">Bilens nummerplpade.</param>
        /// <param name="date">Datoen forbundet med bilen.</param>
        public Car(string licenseplate, DateTime date) : base(licenseplate, date)
        {
        }
    }
}
