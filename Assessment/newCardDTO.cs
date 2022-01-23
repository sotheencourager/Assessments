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
    
        public partial class newCardDTO
    {
            public bool Success { get; set; }
            public string deck_id { get; set; }
            public List<Card> Cards { get; set; }
            public long Remaining { get; set; }
        }

        public partial class Card
        {
            public string Code { get; set; }
            public Uri Image { get; set; }
            public Images Images { get; set; }
            public string Value { get; set; }
            public string Suit { get; set; }
        }

        public partial class Images
        {
            public Uri Svg { get; set; }
            public Uri Png { get; set; }
        }
    }

