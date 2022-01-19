using SqlSugar;
using SugarTableSplit.IServices;
using SugarTableSplit.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SugarTableSplit.Services
{
    public class UserService : BasicService, IUserService
    {
        public UserService()
        {

        }

        public async Task<List<UserEntity>> GetUserList()
        {
            return await DB.Queryable<UserEntity>().SplitTable(tas=>tas.Where(x=>x.TableName.Contains("2022"))).ToListAsync();
        }

        public async Task<string> InsertUser(UserEntity userEntity)
        {
            //var count= await DB.Insertable(userEntity).ExecuteCommandAsync();

            await DB.Insertable(userEntity).SplitTable().ExecuteCommandAsync();

            return "添加成功";
        }


        public async Task<string> UpdateUser(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }


        public async Task<string> DeleteUser(UserEntity userEntity)
        {
            var names = DB.SplitHelper(userEntity).GetTableNames();
            //var entity = DB.Queryable<UserEntity>().Where(x => x.Id == userEntity.Id).SplitTable(tas => tas.InTableNames(name)).ToList();

            await DB.Deleteable<UserEntity>().Where(userEntity).SplitTable(tas => tas.InTableNames(names)).ExecuteCommandAsync();
            return "删除成功";

        }
    }
}
