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
    public class PayloadService : IPayload
    {
        public async Task<List<PayloadModel>> GetAllPayloadsAsync()
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllPayloadsPath}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var payloadList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PayloadModel>>(response.Content);
                return payloadList;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }

        public async Task<PayloadModel> GetOnePayloadAsync(string payload_id)
        {
            var client = new RestClient($"{SpaceXApiPaths.SpaceXApiBaseUrl}");
            var request = new RestRequest($"{SpaceXApiPaths.AllPayloadsPath}/{payload_id}", Method.GET);

            try
            {
                IRestResponse response = client.Execute(request);
                var payload = Newtonsoft.Json.JsonConvert.DeserializeObject<PayloadModel>(response.Content);
                return payload;
            }
            catch (Exception e)
            {
                throw new UserFriendlyExceptions("400", $"{e.Message}", e.StackTrace);
            }
        }
    }
}
