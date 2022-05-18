using Newtonsoft.Json;
using Oico.Data.API;
using Oico.Data.DTO.Requests;
using Oico.Data.DTO.Responses;
using Oico.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Oico.Data
{
    public class AdminRepository : IAdminRepository
    {
        public async Task<BaseResponse> Login(AdminLoginRequest request)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage res = await httpClient.PostAsJsonAsync(AdminAPI.Login, request);

            string response = await res.Content.ReadAsStringAsync();

            BaseResponse result = JsonConvert.DeserializeObject<BaseResponse>(response);

            return result;
        }
    }
}
