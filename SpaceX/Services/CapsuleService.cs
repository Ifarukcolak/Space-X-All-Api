using SpaceX.Interfaces;
using SpaceX.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using SpaceX.Data;
using SpaceX.Models.Errors;
using RestSharp;

namespace SpaceX.Services
{
    class CapsuleService : ICapsule
    {
        public async Task<List<CapsuleModel>> GetAllCapsulesAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllCapsulesPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var capsuleList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CapsuleModel>>(response.Content);
                return capsuleList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<CapsuleModel> GetOneCapsuleAsync(string capsule_serial)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllCapsulesPath}/{capsule_serial}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var capsule = Newtonsoft.Json.JsonConvert.DeserializeObject<CapsuleModel>(response.Content);
                return capsule;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<List<CapsuleModel>> GetPastCapsulesAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.PastCapsulesPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var pastCapsuleList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CapsuleModel>>(response.Content);
                return pastCapsuleList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<List<CapsuleModel>> GetUpcomingCapsulesAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.UpcomingCapsulesPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var upComingCapsuleList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<CapsuleModel>>(response.Content);
                return upComingCapsuleList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
