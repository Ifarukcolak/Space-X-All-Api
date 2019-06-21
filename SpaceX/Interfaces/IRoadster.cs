using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    interface IRoadster
    {
        /// <summary>
        /// Get current roadster orbit data
        /// </summary>
        /// <returns></returns>
        Task<RoadsterModel> GetRoadsterOrbitDataAsync();
    }
}
