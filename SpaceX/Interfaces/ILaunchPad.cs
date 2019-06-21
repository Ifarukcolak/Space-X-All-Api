using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface ILaunchPad
    {
        /// <summary>
        /// Returns all launchpad info
        /// </summary>
        /// <returns></returns>
        Task<List<LaunchPadModel>> GetAllLaunchPadsAsync();

        /// <summary>
        /// Returns a specific launchpad info
        /// </summary>
        /// <param name="site_id"></param>
        /// <returns></returns>
        Task<LaunchPadModel> GetOneLaunchPadAsync(string site_id);
    }
}
