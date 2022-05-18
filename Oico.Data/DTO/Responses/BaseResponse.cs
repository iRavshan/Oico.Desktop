using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oico.Data.DTO.Responses
{
    public class BaseResponse
    {
        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("Errors")]
        public IEnumerable<string> Errors { get; set; }
    }
}
