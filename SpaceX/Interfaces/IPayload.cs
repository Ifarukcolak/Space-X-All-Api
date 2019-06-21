using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IPayload
    {
        /// <summary>
        /// Returns all payloads
        /// </summary>
        /// <returns></returns>
        Task<List<PayloadModel>> GetAllPayloadsAsync();

        /// <summary>
        /// Returns a specific payload info
        /// </summary>
        /// <param name="payload_id"></param>
        /// <returns></returns>
        Task<PayloadModel> GetOnePayloadAsync(string payload_id);
    }
}
