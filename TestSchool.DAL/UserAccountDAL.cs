using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSchool.BO;
using TestSchool.BO.Interface;


namespace TestSchool.DAL
{
    public class UserAccountDAL : IDataAccessLayer<UserAccount>
    {
        public bool Add(UserAccount model)
        {
            throw new NotImplementedException();
        }

        public UserAccount Get(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount Get(UserAccount model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Modify(UserAccount model)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(UserAccount model)
        {
            throw new NotImplementedException();
        }
    }

}
