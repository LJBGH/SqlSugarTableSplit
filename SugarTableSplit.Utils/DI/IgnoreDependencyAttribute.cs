using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarTableSplit.Utils.DI
{   /// <summary>
    /// 配置此特性将忽略依赖注入自动映射
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
    public class IgnoreDependencyAttribute : Attribute
    {

    }
}
