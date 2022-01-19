using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarTableSplit.Utils
{
    public class Appsettings
    {
        //定义全局变量
        static IConfiguration Configuration { get; set; }
        static Appsettings()
        {
            Configuration = new ConfigurationBuilder().Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true }).Build();
        }
        public static string app(params string[] sections)
        {
            try
            {
                var val = string.Empty;
                for (int i = 0; i < sections.Length; i++)
                {
                    val += sections[i] + ":";
                }
                return Configuration[val.TrimEnd(':')];//去除最后一个冒号
            }
            catch (Exception)
            {

                return "";
            }
        }
    }
}
