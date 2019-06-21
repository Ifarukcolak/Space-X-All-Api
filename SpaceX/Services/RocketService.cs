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
    public class RocketService : IRocket
    {
        public async Task<List<RocketModel>> GetAllRocketsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllRocketsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var rocketList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<RocketModel>>(response.Content);
                return rocketList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<RocketModel> GetOneRocketAsync(string rocket_id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllRocketsPath}/{rocket_id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var rocket = Newtonsoft.Json.JsonConvert.DeserializeObject<RocketModel>(response.Content);
                return rocket;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
