using RestaurantAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Repository.Service
{
    public class RepositoryManager : IRepositoryManager
    {
        public IMenuTableRepo Menu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IOrderRepo Order { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IFoodRepo Food { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEmployeeListRepo EmpList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IEmployeeRepo Employee { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IMenuTableRepo EmployeeList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
