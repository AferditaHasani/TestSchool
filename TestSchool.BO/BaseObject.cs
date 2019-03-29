using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSchool.BO
{
    public class BaseObject
    {
        public int InsertBy { get; set; }
        public DateTime InsDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int UpdateNo { get; set; } = 0;
    }
}
