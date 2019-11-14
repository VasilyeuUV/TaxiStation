using System;
using Machinery.Enums;

namespace Machinery.MachinerySystems
{

    /// <summary>
    /// Machinery Brand
    /// </summary>
    public class Brand
    {
        private string _name;

        #region FIELDS
        //##################################################################################################################

        #endregion // FIELDS



        #region PROPERTIES
        //##################################################################################################################

        /// <summary>
        /// Brand name
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrWhiteSpace(_name))
                {
                    _name = value.Trim();
                }                
            }
        }





        #endregion // PROPERTIES


        #region CTOR
        //##################################################################################################################


        public Brand() : this(GetNameRND()){}

        public Brand(string name)
        {
            this.Name = name;
        }

        #endregion // CTOR



        #region METHODS
        //##################################################################################################################

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static string GetNameRND()
        {
            Random rnd = new Random();
            int n = Enum.GetNames(typeof(EnumCarsBrand)).Length;
            n = rnd.Next(1, n);
            return Enum.GetName(typeof(EnumCarsBrand), n);                   
        }

        

        #endregion // METHODS

    }
}
