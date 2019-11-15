namespace Machinery.Builders
{

    /// <summary>
    /// Pattern BUILDER
    /// interface Builder
    /// announces all possible product configuration steps for build Vehicle
    /// </summary>
    public interface IVehicleBuilder
    {

        /// <summary>
        /// Set machinery Brand
        /// </summary>
        void SetBrand();

        /// <summary>
        /// Set macinery engine
        /// </summary>
        void SetEngine();
        
        


    }
}
