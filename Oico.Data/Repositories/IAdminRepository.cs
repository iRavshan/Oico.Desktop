using Oico.Data.DTO.Requests;
using Oico.Data.DTO.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oico.Data.Repositories
{
    public interface IAdminRepository
    {
        Task<BaseResponse> Login(AdminLoginRequest request);
    }
}
