using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IDragon
    {
        /// <summary>
        /// Returns all dragon capsules
        /// </summary>
        /// <returns></returns>
        Task<List<DragonModel>> GetAllDragonsAsync();

        /// <summary>
        /// Get dragon with specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<DragonModel> GetOneDragonAsync(string id);
    }
}
