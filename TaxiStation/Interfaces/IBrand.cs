namespace TaxiStation.Interfaces
{

    /// <summary>
    /// Machinery brand public information
    /// </summary>
    public interface IBrand
    {

        /// <summary>
        /// Brand Name
        /// </summary>
        string Name { get; }


        /// <summary>
        /// Brand name Model
        /// </summary>
        // string Model { get; }

        /// <summary>
        /// Brand model current price
        /// </summary>
        int CurrentPrice { get; }


    }
}
