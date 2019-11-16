using Machinery.Builders;
using Machinery.Vehicles;
using System;

namespace Machinery
{

    /// <summary>
    /// Class for Production any types of machinery 
    /// </summary>
    public static class Production
    {
        internal static Random rnd = new Random();


        #region METHODS
        //##################################################################################################################

        public static Car NewCar()
        {
            var builder = new CarBuilder();
            var director = new VehicleDirector();
            director.VehicleBuilder = builder;
            director.BuildCar();
            return builder.GetCar();
        }


        #endregion // METHODS




    }
}
