
using LibraryManagementSystem.Domain.Model;

namespace LibraryManagementSystem.Service.Interface
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetReservations();
        Reservation GetReservation(Guid id);
    }
}
