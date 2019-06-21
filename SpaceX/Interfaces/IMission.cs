using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IMission
    {
        /// <summary>
        /// Returns all missions
        /// </summary>
        /// <returns></returns>
        Task<List<MissionModel>> GetAllMissionsAsync();

        /// <summary>
        /// Returns a specific mission info
        /// </summary>
        /// <param name="mission_id"></param>
        /// <returns></returns>
        Task<MissionModel> GetOneMissionAsync(string mission_id);
    }
}
