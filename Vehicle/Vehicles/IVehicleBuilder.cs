﻿namespace TaxiStation.Interfaces
{

    /// <summary>
    /// Pattern BUILDER
    /// interface Builder
    /// announces all possible product configuration steps for build Vehicle
    /// </summary>
    interface IVehicleBuilder
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