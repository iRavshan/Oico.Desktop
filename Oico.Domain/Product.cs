using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oico.Domain
{
    public class Product
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("wholesalePrice")]
        public int WholesalePrice { get; set; }

        [JsonProperty("numberOfBox")]
        public int NumberOfBox { get; set; }

        [JsonProperty("numberOfBoxes")]
        public int NumberOfBoxes { get; set; }

        [JsonProperty("numberOfBoxesForSale")]
        public int NumberOfBoxesForSale { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("massa")]
        public int Massa { get; set; }
    }
}
