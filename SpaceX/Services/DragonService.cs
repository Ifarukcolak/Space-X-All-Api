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
    public class DragonService : IDragon
    {
        public async Task<List<DragonModel>> GetAllDragonsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllDragonsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var dragonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DragonModel>>(response.Content);
                return dragonList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<DragonModel> GetOneDragonAsync(string id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllDragonsPath}/{id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var dragon = Newtonsoft.Json.JsonConvert.DeserializeObject<DragonModel>(response.Content);
                return dragon;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
