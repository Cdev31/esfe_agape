﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kalet.ArqLimpia.EN;

namespace Kalet.ArqLimpia.EN.Interfaces
{
    public interface IUser
    {
        void Create(User pUser);
        void Update(User pUser);
        void Delete(User pUser);

        Task<User> GetById(User pUser);
        Task<List<User>> Search(User pUser);

    }
}
