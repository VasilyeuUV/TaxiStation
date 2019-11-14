namespace Machinery.Interfaces
{

    /// <summary>
    /// Сlass object has a price
    /// </summary>
    interface IPriceable
    {

        /// <summary>
        /// Brand model current price
        /// </summary>
        int CurrentPrice { get; set; }
    }
}
