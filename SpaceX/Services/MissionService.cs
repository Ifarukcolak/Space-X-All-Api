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
    public class MissionService : IMission
    {
        public async Task<List<MissionModel>> GetAllMissionsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllMissionsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var missionList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MissionModel>>(response.Content);
                return missionList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<MissionModel> GetOneMissionAsync(string mission_id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllMissionsPath}/{mission_id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var mission = Newtonsoft.Json.JsonConvert.DeserializeObject<MissionModel>(response.Content);
                return mission;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
