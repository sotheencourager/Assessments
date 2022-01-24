using Newtonsoft.Json;
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
      
        public newCardDTO CreateCard()
        {
          
            var client = new RestClient("http://deckofcardsapi.com/api/deck/");
            var request = new RestRequest("new/", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            
            IRestResponse response = client.Execute(request);
            var resData = response.Content;


            var newCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return newCard;

        }

    
        public newCardDTO CreateCardWithJoker()
        {

            string prompt;
            string req = "";
            Console.Write("Do you want to include two Jokers in the deck? Y/N: ");
            prompt = Console.ReadLine();

            
            //if (prompt == "Y")
            //{
            //    req = "http://deckofcardsapi.com/api/deck/new/?jokers_enabled=true";
            //}
            //else if (prompt == "N")
            //{
            //    //req = "http://deckofcardsapi.com/api/deck/new";
            //    CreateCard();
            //}
            req = "http://deckofcardsapi.com/api/deck/new/?jokers_enabled=true";
            var client = new RestClient(req);
            var request = new RestRequest("/", Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = client.Execute(request);
            var resData = response.Content;

            var newCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return newCard;
        }
     
        public newCardDTO shuffleCards()
        {
            Random rand = new Random();
            int d_count = rand.Next(1, 6);
            string endPoint = "new/shuffle/?deck_count="+ d_count+"/";
            
            var client = new RestClient("http://deckofcardsapi.com/api/deck/");
            var request = new RestRequest(endPoint, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = client.Execute(request);
            var resData = response.Content;

            var shuffleCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return shuffleCard;
        }
    
        public newCardDTO reShuffleCards(string deck_id)
        {
            string endPoint = deck_id + "/shuffle/?remaining=true";

            var client = new RestClient("http://deckofcardsapi.com/api/deck/");
            var request = new RestRequest(endPoint, Method.POST);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;


            IRestResponse response = client.Execute(request);
            var resData = response.Content;

            var reshuffleCard = JsonConvert.DeserializeObject<newCardDTO>(resData);
            return reshuffleCard;
        }
    }
}
