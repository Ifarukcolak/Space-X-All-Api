using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface ILandingPad
    {
        /// <summary>
        /// Returns all landing pads
        /// </summary>
        /// <returns></returns>
        Task<List<LandingPadModel>> GetAllLandingPadsAsync();

        /// <summary>
        /// Returns a specific landing pad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<LandingPadModel> GetOneLandingPadAsync(int id);
    }
}
