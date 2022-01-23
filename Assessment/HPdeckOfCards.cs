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
            string endPoint = deckIs + "/draw/?count=2";

            // arrange
            var client = new RestClient("http://deckofcardsapi.com/api/deck/");
            var request = new RestRequest(endPoint, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            // act
            IRestResponse response = client.Execute(request);
            var resData = response.Content;

            // assert
            //Assert.That(response.ContentType, Is.EqualTo("application/json"));

            var newCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return newCard;


        }
    }
}
