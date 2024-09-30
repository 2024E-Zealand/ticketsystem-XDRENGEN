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
        /// Nummerpladen må være på max 7 tegn.
        /// </summary>
        public string Licenseplate
        {
            get { return _licenseplate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen må ikke indeholde mere end 7 tegn.");
                }
                _licenseplate = value;
            }
        }

        /// <summary>
        /// Henter eller sætter datoen for køretøjet.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Her angives det om BroBizzen bliver brugt.
        /// Den er sat til false som standart (bliver ikke brugt)
        /// </summary>
        public bool BroBizzUsed { get; set; } = false;




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

        /// <summary>
        /// Her bregnes rabatten med BroBizz som er 5%.
        /// </summary>
        /// <returns></returns>
        public double PriceWithDiscount()
        {
            double originalPrice = Price();
            if (BroBizzUsed)
            {
                return originalPrice * 0.95;
            }
            return originalPrice;
        }




        // Konstruktør

        /// <summary>
        /// Initialiserer en ny instans af Vehicle klassen men en nummerplade og dato.
        /// </summary>
        /// <param name="licenseplate">Nummerpladen på køretøjet.</param>
        /// <param name="date">Datoen forbundet med køretøjet.</param>
        /// <param name="broBizzUsed">Angives om BroBizzen bliver brugt.</param>
        protected Vehicle(string licenseplate, DateTime date, bool broBizzUsed)
        {
            Licenseplate = licenseplate;
            Date = date;
            BroBizzUsed = broBizzUsed;
        }
    }
}
