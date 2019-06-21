using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface ILaunch
    {
        /// <summary>
        /// Get all launches
        /// </summary>
        /// <returns></returns>
        Task<List<LaunchModel>> GetAllLaunchesAsync();

        /// <summary>
        /// Get launch with specified capsule_serial
        /// </summary>
        /// <param name="flight_number  "></param>
        /// <returns></returns>
        Task<LaunchModel> GetOneLaunchAsync(string flight_number);

        /// <summary>
        /// Lists launches that haven't launched yet
        /// </summary>
        Task<List<LaunchModel>> GetUpcominLaunchesAsync();

        /// <summary>
        /// Lists launches that have launched
        /// </summary>
        /// <returns></returns>
        Task<List<LaunchModel>> GetPastLaunchesAsync();

        /// <summary>
        /// Returns the most recent launch
        /// </summary>
        /// <returns></returns>
        Task<LaunchModel> GetLatestLaunchAsync();

        /// <summary>
        /// Returns the closest upcoming launch
        /// </summary>
        /// <returns></returns>
        Task<LaunchModel> GetNextLaunchAsync();
    }
}
