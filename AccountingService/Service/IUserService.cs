using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingService.Service
{
   public interface IUserService
    {
        string GetGreeting(string name);
        int CalculateSum(int a, int b);

        string GetUserName(int userId);
    }
}
