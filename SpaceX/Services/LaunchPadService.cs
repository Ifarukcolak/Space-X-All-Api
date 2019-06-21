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
    class LaunchPadService : ILaunchPad
    {
        public async Task<List<LaunchPadModel>> GetAllLaunchPadsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllLaunchPadsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var launchPadList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LaunchPadModel>>(response.Content);
                return launchPadList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<LaunchPadModel> GetOneLaunchPadAsync(string site_id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllLaunchPadsPath}/{site_id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var launchPad = Newtonsoft.Json.JsonConvert.DeserializeObject<LaunchPadModel>(response.Content);
                return launchPad;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
