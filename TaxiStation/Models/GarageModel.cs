using System.Collections;

namespace TaxiStation.Models
{
    public class GarageModel
    {

        #region FIELDS
        //##################################################################################################################


        private ArrayList _vehicles = new ArrayList();      // any type vehicles list



        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public GarageModel()
        {

        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// Add new vehicles list
        /// </summary>
        /// <param name="lst">ICollection vehicles list</param>
        public void Add(ICollection lst)
        {
            this._vehicles.Add(lst);
        }



        #endregion // METHODS





    }
}