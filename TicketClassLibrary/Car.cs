﻿namespace TicketClassLibrary
{
    /// <summary>
    /// Beskriver en bil med en licenseplate og date.
    /// </summary>
    public class Car
    {
        // Instansfelter
        /// <summary>
        /// Bilens nummerplade.
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// Dato, f.eks. dato for overfart af bro.
        /// </summary>
        private DateTime _date;


        // Properties
        /// <summary>
        /// Henter eller sætter bilens nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Henter eller sætter datoen.
        /// </summary>
        public DateTime Date { get; set; }


        //Metoder
        /// <summary>
        /// Returnerer bilens faste pris.
        /// </summary>
        /// <returns>Den faste pris på 240.</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returnerer typen af bil.
        /// </summary>
        /// <returns>Strengen "Car"</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
