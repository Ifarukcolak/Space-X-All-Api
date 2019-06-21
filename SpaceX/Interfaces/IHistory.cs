using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IHistory
    {
        /// <summary>
        /// Returns all historical events
        /// </summary>
        /// <returns></returns>
        Task<List<HistoryModel>> GetAllHistoricalEventsAsync();

        /// <summary>
        /// Get one historical event with specified id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<HistoryModel> GetOneHistoricalEventAsync(int id);
    }
}
