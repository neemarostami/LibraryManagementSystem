
using LibraryManagementSystem.Domain.Model;

namespace LibraryManagementSystem.Service.Interface
{
    public interface IReservationDetailService
    {
        ReservationDetail GetReservationDetail(Guid id);
    }
}
