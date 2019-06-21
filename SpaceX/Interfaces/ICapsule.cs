using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface ICapsule
    {
        /// <summary>
        /// Get all capsules
        /// </summary>
        /// <returns></returns>
        Task<List<CapsuleModel>> GetAllCapsulesAsync();

        /// <summary>
        /// Get capsule with specified capsule_serial
        /// </summary>
        /// <param name="capsule_serial"></param>
        /// <returns></returns>
        Task<CapsuleModel> GetOneCapsuleAsync(string capsule_serial);

        /// <summary>
        /// Lists capsules that haven't launched yet
        /// </summary>
        Task<List<CapsuleModel>> GetUpcomingCapsulesAsync();

        /// <summary>
        /// Lists capsules that have launched
        /// </summary>
        /// <returns></returns>
        Task<List<CapsuleModel>> GetPastCapsulesAsync();
    }
}
