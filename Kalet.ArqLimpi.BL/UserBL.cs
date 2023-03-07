using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kalet.ArqLimpia.BL.Interfaces;
using Kalet.ArqLimpia.EN;
using Kalet.ArqLimpia.EN.Interfaces;
using Kalet.ArqLimpia.BL.DTOs.UserDTOs;

namespace Kalet.ArqLimpi.BL
{
    public class UserBL: IUserBL
    {
        readonly IUser userDAL;
        readonly IUnityOfWork UnityWork;
        public UserBL(IUser pUserDAL, IUnityOfWork pUnitWork)
        {
            userDAL = pUserDAL;
            UnityWork = pUnitWork;
        }
        public async Task<CreateUserOutputDTOs> Create(CreateUserInputDTOs pUser)
        {
            User user = new User
            {
                Email = pUser.Email,
                Password = pUser.Password,
                Name = pUser.Name
            };
            userDAL.Create(user);
            await UnityWork.SaveChangesAsync();
            CreateUserOutputDTOs userOutput = new CreateUserOutputDTOs
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name
            };
            return userOutput;
        }

        public async Task<int> Delete(DeleteUserDTOs pUser)
        {
            User user = await userDAL.GetById(new User { Id = pUser.Id });
            if (user.Id == pUser.Id)
            {
                userDAL.Delete(user);
                return await UnityWork.SaveChangesAsync();
            }
            else
                return 0;
        }

        public async Task<GetByIdUserOutputDTOs> GetById(GetByIdUserInputDTOs pUser)
        {
            User user = await userDAL.GetById(new User { Id = pUser.Id });
            return new GetByIdUserOutputDTOs
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email
            };
        }

        public async Task<List<SearchUserOutputDTOs>> Search(SearchUserInputDTOs pUser)
        {
            List<User> users = await userDAL.Search(new User { Email = pUser.Email, Name = pUser.Name });
            List<SearchUserOutputDTOs> list = new List<SearchUserOutputDTOs>();
            users.ForEach(s => list.Add(new SearchUserOutputDTOs
            {
                Id = s.Id,
                Email = s.Email,
                Name = s.Name
            }));
            return list;
        }

        public async Task<int> Update(UpdateUserDTOs pUser)
        {
            User user = await userDAL.GetById(new User { Id = pUser.Id });
            if (user.Id == pUser.Id)
            {
                user.Name = pUser.Name;
                userDAL.Update(user);
                return await UnityWork.SaveChangesAsync();
            }
            else
                return 0;
        }
    }
}
