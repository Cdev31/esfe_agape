using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kalet.ArqLimpia.BL.DTOs.UserDTOs;

namespace Kalet.ArqLimpia.BL.Interfaces
{
    public interface IUserBL
    {
        Task<CreateUserOutputDTOs> Create(CreateUserInputDTOs createUserInputDTOs);
        Task<int> Update(UpdateUserDTOs pUser);
        Task<int> Delete(DeleteUserDTOs pUser);
        Task<List<SearchUserOutputDTOs>> Search(SearchUserInputDTOs pUser);

    }
}
