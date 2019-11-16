using Machinery.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TaxiStation.Models
{

    /// <summary>
    /// Initializer TaxiStation
    /// Get TaxiStation data from file or create new TaxiStation
    /// REMARK: realization "Get Taxistaion data from file" will be done if necessary
    /// </summary>
    public static class TaxiStationInitializer
    {

        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Create ne TaxiStation
        /// </summary>
        /// <returns> null or TaxiStationModel object</returns>
        public static TaxiStationModel CreateTaxiStation(string fileName)
        {
            if (String.IsNullOrWhiteSpace(fileName)
                || !File.Exists("filename.txt"))
                { return new TaxiStationModel(); }

            List<object> vehicles = ReadFile(fileName);
            return new TaxiStationModel(vehicles);
        }

        /// <summary>
        /// Read Vehicles from file
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private static List<object> ReadFile(string fileName)
        {
            return null;
        }


        /// <summary>
        /// Write TaiStation Data to file
        /// </summary>
        /// <param name="fileName"></param>
        private static void WriteToFile(string fileName)
        {
        }


        #endregion // METHODS

    }
}
