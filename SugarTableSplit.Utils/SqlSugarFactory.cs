using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarTableSplit.Utils
{
    public class SqlSugarFactory
    {
        public SqlSugarClient GetMysqlDb(string conn)
        {
            return this.GetInstance(DbType.MySql, conn);
        }

        public SqlSugarClient GetSqlserverDb(string conn)
        {
            return this.GetInstance(DbType.SqlServer, conn);
        }

        /// <summary>
        /// 返回SqlSugar数据库实例
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        private SqlSugarClient GetInstance(DbType dbType, string conn)
        {
            //创建数据库对象
            return new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = conn,//连接符字串
                DbType = dbType,// DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键自增信息
            });
        }

        public static SqlSugarClient GetDB(string type, string conn)
        {
            DbType dbType = DbType.SqlServer;
            if ("MySql".Equals(type, StringComparison.CurrentCultureIgnoreCase))
            {
                dbType = DbType.MySql;
            }

            //创建数据库对象
            var db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = conn,//连接符字串
                DbType = dbType,// DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键自增信息
            });

            //db.Aop.OnLogExecuting = (sql, pars) =>
            //{
            //    Console.WriteLine($"{ DateTime.Now.ToString()}  SQL执行前: \r\n{sql}");
            //};
            return db;
        }

    }
}
