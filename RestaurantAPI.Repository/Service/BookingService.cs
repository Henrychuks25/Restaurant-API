using RestaurantAPI.Entities.ModelContexts;
using RestaurantAPI.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Repository.Service
{
    public class BookingService : RepositoryBase<Booking>, IBookingRepo
    {
        public BookingService(Contexts contexts)
            :base(contexts)
        {

        }
    }
}
