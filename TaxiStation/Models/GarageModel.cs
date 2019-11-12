using System.Collections.Generic;

namespace TaxiStation.Models
{
    public class GarageModel
    {

        #region FIELDS
        //##################################################################################################################


        private List<object> _vehiclesList = new List<object>();
        


        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        public void AddVehicleLst(object lst)
        {
            this._vehiclesList.Add(lst);
        }


        #endregion // METHODS





    }
}