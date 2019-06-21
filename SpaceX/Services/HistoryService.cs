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
    public class HistoryService : IHistory
    {
        public async Task<List<HistoryModel>> GetAllHistoricalEventsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllHistoricalEventsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var historicalEventList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<HistoryModel>>(response.Content);
                return historicalEventList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<HistoryModel> GetOneHistoricalEventAsync(int id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllHistoricalEventsPath}/{id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var historicalEvent = Newtonsoft.Json.JsonConvert.DeserializeObject<HistoryModel>(response.Content);
                return historicalEvent;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
