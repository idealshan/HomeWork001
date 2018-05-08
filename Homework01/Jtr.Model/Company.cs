using Jtr.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jtr.Model
{
    public class Company : BaseModel
    {
        //[Leng(2, 8)]
        //[DisplayAttritube("公司名称")]
        public string Name { get; set; }
        public int CreatorId { get; set; }
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 必须是可空类型，才能跟数据库对应
        /// </summary>
        public int? LastModifierId { get; set; }
        public DateTime? LastModifyTime { get; set; }
    }
}
