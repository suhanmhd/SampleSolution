using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingService.Service.Impl
{
    public class UserService : IUserService
    {
        private readonly IRepository _repository;
        public UserService(IRepository repository) {
            _repository = repository;
        }
        public string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }

        public int CalculateSum(int a, int b)
        {
            return a + b;
        }

        public string GetUserName(int userId)
        {
            return _repository.GetUserNameById(userId);
        }
    }
}
