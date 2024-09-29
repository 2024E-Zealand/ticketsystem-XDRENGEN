using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// Beskriver en MC med en licenseplate og date.
    /// </summary>
    public class MC : Vehicle
    {
        // Metoder

        /// <summary>
        /// Returnerer MC's faste pris.
        /// </summary>
        /// <returns>Den faste pris på 125</returns>
        public override double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returnerer typen som "MC" 
        /// </summary>
        /// <returns>strengen "MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }




        // Konstruktør

        /// <summary>
        /// Initialiserer en ny instans af MC-klassen.
        /// </summary>
        /// <param name="licenseplate">MC's nummerplade.</param>
        /// <param name="date">Datoen forbundet med MC.</param>
        public MC(string licenseplate, DateTime date) : base(licenseplate, date)
        {
        }
    }
}
