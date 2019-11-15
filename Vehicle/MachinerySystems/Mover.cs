using Machinery.MachinerySystems.Engines;

namespace Machinery.MachinerySystems
{


    /// <summary>
    /// Used engine in machinery
    /// </summary>
    public class Mover 
    {


        #region FIELDS
        //##################################################################################################################


        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################

        public dynamic Model { get; private set; }


        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################

        public Mover()
        {
            this.Model = new DieselEngine();
        }


        #endregion // CTOR



        #region METHODS
        //##################################################################################################################





        #endregion // METHODS

    }
}
