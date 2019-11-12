namespace TaxiStation.Interfaces
{

    /// <summary>
    /// PATTERN BUILDER
    /// Builder Intrface
    /// define the main methods for creating a TaxiStation
    /// </summary>
    public interface ITaxiStationBuilder
    {
        /// <summary>
        /// Create TaxiStation Adminictration
        /// </summary>
        void CreateAdministration();

        /// <summary>
        /// Create TaxiStation Garage
        /// </summary>
        void CreateGarage();

    }
}
