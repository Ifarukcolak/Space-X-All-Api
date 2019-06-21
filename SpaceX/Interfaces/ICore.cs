using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface ICore
    {
        /// <summary>
        /// Get all cores
        /// </summary>
        /// <returns></returns>
        Task<List<CoreModel>> GetAllCoresAsync();

        /// <summary>
        /// Get core with specified capsule_serial
        /// </summary>
        /// <param name="core_serial"></param>
        /// <returns></returns>
        Task<CoreModel> GetOneCoreAsync(string core_serial);

        /// <summary>
        /// Lists cores that haven't launched yet
        /// </summary>
        Task<List<CoreModel>> GetUpcomingCoresAsync();

        /// <summary>
        /// Lists cores that have launched
        /// </summary>
        /// <returns></returns>
        Task<List<CoreModel>> GetPastCoresAsync();
    }
}
