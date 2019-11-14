using System.Collections;
using System.Collections.Generic;
using TaxiStation.Vehicles;

namespace TaxiStation.Models
{
    public class GarageModel
    {

        #region FIELDS
        //##################################################################################################################
        
        private Dictionary<string, ICollection> _vehicles = new Dictionary<string, ICollection>();      // any type vehicles list
               
        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################

        internal Dictionary<string, ICollection> Vehicles { get => _vehicles; }

        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Add new vehicles list
        /// </summary>
        /// <param name="vType">typeName of vehicles list</param>
        /// <param name="lst">vehicles list </param>
        public void Add(string vType, ICollection lst)
        {
            this.Vehicles.Add(vType, lst);
        }

        #endregion // METHODS





    }
}