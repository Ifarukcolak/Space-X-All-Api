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
    public class LandingPadService : ILandingPad
    {
        public async Task<List<LandingPadModel>> GetAllLandingPadsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllLandingPadsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var landingPadList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<LandingPadModel>>(response.Content);
                return landingPadList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<LandingPadModel> GetOneLandingPadAsync(int id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllLandingPadsPath}/{id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var landingPad = Newtonsoft.Json.JsonConvert.DeserializeObject<LandingPadModel>(response.Content);
                return landingPad;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
