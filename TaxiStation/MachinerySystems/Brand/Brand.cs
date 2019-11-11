using TaxiStation.Interfaces;

namespace TaxiStation.MachinerySystems.Brand
{

    /// <summary>
    /// Machinery Brand
    /// </summary>
    public class Brand
    {

        #region FIELDS
        //##################################################################################################################

        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// Machinery brand Name
        /// </summary>
        public string Name { get; private set; }



        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public Brand(string name)
        {
            this.Name = name;
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################


        #endregion // METHODS


    }
}
