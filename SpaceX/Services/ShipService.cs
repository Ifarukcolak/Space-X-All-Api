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
    public class ShipService : IShip
    {
        public async Task<List<ShipModel>> GetAllShipsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllShipsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var shipList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ShipModel>>(response.Content);
                return shipList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<ShipModel> GetOneShipAsync(string ship_id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllShipsPath}/{ship_id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var ship = Newtonsoft.Json.JsonConvert.DeserializeObject<ShipModel>(response.Content);
                return ship;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
