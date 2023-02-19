using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Repository.Interface
{
    public interface IRepositoryManager
    {
<<<<<<< Updated upstream

=======
        IMenuTableRepo Menu {get; set;}
        IOrderRepo Order {get; set;}
        IFoodRepo Food {get; set;}
        IEmployeeListRepo EmpList {get; set;}
        IEmployeeRepo Employee {get; set;}
        IMenuTableRepo EmployeeList {get; set;}
        IBookingRepo Booking { get; set; }
        ICustomerRepo Customer { get; set; }
        IItemRepo Item { get; set; }

        Task SaveAsync();
>>>>>>> Stashed changes
    }
}
