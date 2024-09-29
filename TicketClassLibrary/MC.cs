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
    public class MC
    {
        /// <summary>
        /// MC's nummerplade
        /// </summary>
        private string _licenseplate;

        /// <summary>
        /// Dato, f.eks. dato for overfart af bro.
        /// </summary>
        private DateTime _date;


        /// <summary>
        /// Henter eller sætter MC's nummerplade.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Henter eller sætter datoen.
        /// </summary>
        public DateTime Date { get; set; }


        /// <summary>
        /// Returnerer MC's faste pris.
        /// </summary>
        /// <returns>Den faste pris på 125</returns>
        public double Price()
        {
            return 125;
        }

        /// <summary>
        /// Returnerer typen som "MC" 
        /// </summary>
        /// <returns>strengen "MC"</returns>
        public string Vehicle()
        {
            return "MC";
        }
    }
}
