namespace TaxiStation.Interfaces
{
    public interface IFuelConsumptionVehicle : IFuelConsumption
    {

        /// <summary>
        /// Fuel consumption in the city
        /// </summary>
        int FuelConsumptionTown { get; }

    }
}
