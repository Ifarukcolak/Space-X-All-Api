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
    public class LaunchService : ILaunch
    {
        public async Task<List<LaunchModel>> GetAllLaunchesAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllLaunchesPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var launchList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LaunchModel>>(response.Content);
                return launchList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<LaunchModel> GetLatestLaunchAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.LatestLaunchPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var latestLaunch = Newtonsoft.Json.JsonConvert.DeserializeObject<LaunchModel>(response.Content);
                return latestLaunch;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<LaunchModel> GetNextLaunchAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.NextLaunchPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var nextLaunch = Newtonsoft.Json.JsonConvert.DeserializeObject<LaunchModel>(response.Content);
                return nextLaunch;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<LaunchModel> GetOneLaunchAsync(string flight_number)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllLaunchesPath}/{flight_number}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var launch = Newtonsoft.Json.JsonConvert.DeserializeObject<LaunchModel>(response.Content);
                return launch;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<List<LaunchModel>> GetPastLaunchesAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.PastLaunchesPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var pastLaunchesList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LaunchModel>>(response.Content);
                return pastLaunchesList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<List<LaunchModel>> GetUpcominLaunchesAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.UpcomingLaunchesPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var upComingLaunchList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LaunchModel>>(response.Content);
                return upComingLaunchList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
