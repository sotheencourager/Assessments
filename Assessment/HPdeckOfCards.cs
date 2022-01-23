using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class HPdeckOfCards
    {
         [Test]
        public newCardDTO DrawCard()
        {
            string deckIs = "rdtelv6kej9b";
            string endPoint = deckIs + "/draw";

            var client = new RestClient("http://deckofcardsapi.com/api/deck/");
            var request = new RestRequest(endPoint, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            
            IRestResponse response = client.Execute(request);
            var resData = response.Content;

            var drawCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return drawCard;


        }
        [Test]
        public newCardDTO CreateCard()
        {
          
            var client = new RestClient("http://deckofcardsapi.com/api/deck/new");
            var request = new RestRequest("/", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            
            IRestResponse response = client.Execute(request);
            var resData = response.Content;


            var newCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return newCard;


        }

        [Test]
        public newCardDTO CreateCardWithJoker()
        {

            var client = new RestClient("http://deckofcardsapi.com/api/deck/new/?jokers_enabled=true");
            var request = new RestRequest("/", Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = client.Execute(request);
            var resData = response.Content;


            var newCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return newCard;


        }
    }
}
