﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Models
{
    public class TaxiStationModel
    {

        #region FIELDS
        //##################################################################################################################

        private GarageModel _garage;    // passenger cars in autopark 


        #endregion // FIELDS




        #region PROPERTIES
        //##################################################################################################################


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public TaxiStationModel()
        {
            _garage = new GarageModel()
            {

            };
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        #endregion // METHODS


    }
}
