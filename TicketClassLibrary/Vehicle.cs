using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    /// <summary>
    /// En basisklasse som specialized klasser kan arve fra.
    /// </summary>
    public abstract class Vehicle
    {
        // Instansfelter

        /// <summary>
        /// Køretøjets nummerplade.
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// Køretøjets dato.
        /// </summary>
        private DateTime _date;




        // Properties

        /// <summary>
        /// Henter eller sætter køretøjets nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Henter eller sætter datoen for køretøjet.
        /// </summary>
        public DateTime Date { get; set; }




        // Metoder

        /// <summary>
        /// Returnerer prisen for et køretøj.
        /// </summary>
        /// <returns>Prisen som en double.</returns>
        public abstract double Price();

        /// <summary>
        /// Returnerer køretøjstypen.
        /// </summary>
        /// <returns>Køretøjstypen som en string.</returns>
        public abstract string VehicleType();




        // Konstruktør

        /// <summary>
        /// Initialiserer en ny instans af Vehicle klassen men en nummerplade og dato.
        /// </summary>
        /// <param name="licenseplate">Nummerpladen på køretøjet.</param>
        /// <param name="date">Datoen forbundet med køretøjet.</param>
        protected Vehicle(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }
    }
}
