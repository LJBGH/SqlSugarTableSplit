using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SugarTableSplit.Utils.Extensions
{
    public static class ObjectExtension
    {

        /// <summary>
        /// 判断相应特性是否存在
        /// </summary>
        /// <typeparam name="T">动态类型要判断的特性</typeparam>
        /// <param name="memberInfo"></param>
        /// <param name="inherit"></param>
        /// <returns>如果存在还在返回true，否则返回false</returns>
        public static bool HasAttribute<T>(this MemberInfo memberInfo, bool inherit = true) where T : Attribute
        {
            return memberInfo.IsDefined(typeof(T), inherit);
        }
    }
}
