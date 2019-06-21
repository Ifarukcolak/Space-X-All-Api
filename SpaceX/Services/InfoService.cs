using RestSharp;
using SpaceX.Data;
using SpaceX.Interfaces;
using SpaceX.Models;
using SpaceX.Models.Errors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpaceX.Services
{
    public class InfoService : IInfo
    {
        public async Task<ApiInfoModel> GetApiInfoAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var apiInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<ApiInfoModel>(response.Content);
                return apiInfo;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<CompanyInfoModel> GetCompanyInfoAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.CompanyInfoPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var companyInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<CompanyInfoModel>(response.Content);
                return companyInfo;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
