using TicketClassLibrary;
using System;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Tilbyder prislogik for biler, der krydser Storebæltsbroen.
    /// </summary>
    public class StoreBaeltCars
    {
        /// <summary>
        /// Beregner prisen med rabatterne BroBizz rabat og weekend rabat.
        /// </summary>
        /// <param name="v">Køretøjet som prisen beregnes for.</param>
        /// <returns>Returnere prisen med 20% rabat hvis det er weekend
        /// og yderligere 5% rabat hvis der er anvendt BroBizz.</returns>
        public double PriceWithDiscount(Vehicle v)
        {
            double originalPrice = v.Price();

            if (v is Car && (v.Date.DayOfWeek == DayOfWeek.Saturday || v.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                originalPrice *= 0.80;
            }


            if (v.BroBizzUsed)
            {
                originalPrice *= 0.95;
            }   
            
            return originalPrice;
        }
    }
}
