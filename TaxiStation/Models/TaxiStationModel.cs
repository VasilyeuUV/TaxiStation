using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Models
{
    public class TaxiStationModel
    {

        #region Fields
        //##################################################################################################################

        private AutoParkModel _cars;    // passenger cars in autopark 


        #endregion // Fields




        #region PROPERTIES
        //##################################################################################################################


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public TaxiStationModel()
        {
            _cars = new AutoParkModel()
            {

            };
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        #endregion // METHODS


    }
}
