using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jtr.Framework
{
    public class StaticConstant
    {
        /// <summary>
        /// 静态常量  数据库连接字符串    读取配置文件中的sqlserver数据库连接
        /// </summary>
        public static string SqlServerConnString = ConfigurationManager.ConnectionStrings["JtrConnString"].ConnectionString;

        private static string DALTypeDll = ConfigurationManager.AppSettings["DALTypeDll"];
        public static string DALDllName = DALTypeDll.Split(',')[1];
        public static string DALTypeName = DALTypeDll.Split(',')[0];
    }
}
