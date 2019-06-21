using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IShip
    {
        /// <summary>
        /// Returns all ships
        /// </summary>
        /// <returns></returns>
        Task<List<ShipModel>> GetAllShipsAsync();

        /// <summary>
        /// Returns a specific ship info
        /// </summary>
        /// <param name="ship_id"></param>
        /// <returns></returns>
        Task<ShipModel> GetOneShipAsync(string ship_id);
    }
}
