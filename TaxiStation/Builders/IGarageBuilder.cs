using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Builders
{

    /// <summary>
    /// piece by piece Garage design interface
    /// </summary>
    interface IGarageBuilder
    {

        /// <summary>
        /// Create Car List in Garage
        /// </summary>
        void BuildCarList();

        ///// <summary>
        ///// Create Truck List in Garage
        ///// </summary>
        //void BuildTruckList();
        
    }
}
