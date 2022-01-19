using SugarTableSplit.Model.User;
using SugarTableSplit.Utils.DI;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SugarTableSplit.IServices
{
    public interface IUserService : IScopedDependency
    {
        Task<string> InsertUser(UserEntity userEntity);

        Task<string> UpdateUser(UserEntity userEntity);

        Task<List<UserEntity>> GetUserList();

        Task<string> DeleteUser(UserEntity userEntity);
    }
}
