using TaxiStation.Enums;

namespace TaxiStation.Interfaces
{
    public interface IFuelConsumption
    {

        ///// <summary>
        ///// Average engine fuel consumption
        ///// </summary>
        // int FuelConsumptionAverage { get; }

        /// <summary>
        /// Fuel consumption in the city
        /// </summary>
        int FuelConsumptionTown { get; }

    }
}
