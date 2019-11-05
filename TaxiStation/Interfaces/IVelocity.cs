using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiStation.Interfaces
{
    /// <summary>
    /// General Velocity parameters 
    /// </summary>
    public interface IVelocity
    {
        /// <summary>
        /// Сurrent object speed
        /// </summary>
        int CurrentVelocity { get; set; }

        /// <summary>
        /// Maximum object speed
        /// </summary>
        int MaxVelocity { get; set; }
    }
}
