using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Repository.Interface
{
    public interface IRepositoryManager
    {

        IMenuTableRepo Menu {get; }
        IOrderRepo Order {get; }
        IFoodRepo Food {get;}
        IEmployeeListRepo EmpList {get; }
        IEmployeeRepo Employee {get;}
        IBookingRepo Booking { get;  }
        ICustomerRepo Customer { get;  }
        IItemRepo Item { get; }

        Task SaveAsync();

    }
}
