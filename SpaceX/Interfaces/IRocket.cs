using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IRocket
    {
        /// <summary>
        /// Returns all rockets
        /// </summary>
        /// <returns></returns>
        Task<List<RocketModel>> GetAllRocketsAsync();

        /// <summary>
        /// Returns a specific rocket info
        /// </summary>
        /// <param name="rocket_id"></param>
        /// <returns></returns>
        Task<RocketModel> GetOneRocketAsync(string rocket_id);
    }
}
