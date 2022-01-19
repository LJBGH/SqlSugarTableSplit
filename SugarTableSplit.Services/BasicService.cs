using SqlSugar;
using SugarTableSplit.Model.User;
using SugarTableSplit.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarTableSplit.Services
{
    public class BasicService
    {
        protected SqlSugarClient DB;
        public BasicService()
        {
            var dbConn = Appsettings.app(new string[] { "Database", "BaseDb", "ConnectionString" });
            var dbType = Appsettings.app(new string[] { "Database", "BaseDb", "DatabaseType" });         
            DB = SqlSugarFactory.GetDB(dbType, dbConn);


            //程序启动时加这一行,如果一张表没有会初始化一张
            //DB.CodeFirst.SplitTables().InitTables<UserEntity>();
        }
    }
}
