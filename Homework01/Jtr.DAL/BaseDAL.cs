using Jtr.Framework;
using Jtr.Framework.Model;
using Jtr.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jtr.DAL
{
    public class BaseDAL
    {

        /// <summary>
        /// 泛型查询，按表名和id进行查询
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>

        public T Find<T>(int id) where T : BaseModel
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.Name}]"));
            string sql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id={id}";
            T t = (T)Activator.CreateInstance(type);
            using (SqlConnection conn = new SqlConnection(StaticConstant.SqlServerConnString))
            {
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();


                if (reader.Read())//表示有数据  开始读
                {
                    foreach (var prop in type.GetProperties())
                    {
                        prop.SetValue(t, reader[prop.Name] is DBNull ? null : reader[prop.Name]);
                        Console.WriteLine(prop.Name);
                    }
                }


            }

            return t;
        }

    }
}
