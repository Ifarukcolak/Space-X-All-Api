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
    class RoadsterService : IRoadster
    {
        public async Task<RoadsterModel> GetRoadsterOrbitDataAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.RoadsterPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var roadsterOrbitData = Newtonsoft.Json.JsonConvert.DeserializeObject<RoadsterModel>(response.Content);
                return roadsterOrbitData;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
