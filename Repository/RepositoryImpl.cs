using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public class RepositoryImpl : IRepository
    {
        public string GetUserNameById(int userId)
        {
          
            return $"User_{userId}";
        }


    }
}
