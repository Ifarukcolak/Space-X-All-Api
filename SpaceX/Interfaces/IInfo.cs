using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Interfaces
{
    public interface IInfo
    {

        /// <summary>
        /// Returns all company info 
        /// </summary>
        /// <returns></returns>
        Task<CompanyInfoModel> GetCompanyInfoAsync();

        /// <summary>
        ///Returns details about the API
        /// </summary>
        /// <returns></returns>
        Task<ApiInfoModel> GetApiInfoAsync();
    }
}
