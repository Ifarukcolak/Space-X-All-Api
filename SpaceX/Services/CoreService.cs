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
    public class CoreService : ICore
    {
        public async Task<List<CoreModel>> GetAllCoresAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllCoresPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var coreList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CoreModel>>(response.Content);
                return coreList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<CoreModel> GetOneCoreAsync(string core_serial)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllCoresPath}/{core_serial}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var core = Newtonsoft.Json.JsonConvert.DeserializeObject<CoreModel>(response.Content);
                return core;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<List<CoreModel>> GetPastCoresAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.PastCoresPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var pastCoreList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CoreModel>>(response.Content);
                return pastCoreList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<List<CoreModel>> GetUpcomingCoresAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.UpcomingCoresPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var upComingCoreList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CoreModel>>(response.Content);
                return upComingCoreList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
