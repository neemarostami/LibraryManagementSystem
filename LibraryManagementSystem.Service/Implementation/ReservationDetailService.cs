using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service.Interface;

namespace LibraryManagementSystem.Service.Implementation
{
    public class ReservationDetailService : IReservationDetailService
    {
        private IRepository<ReservationDetail> reservationDetailRepository;

        public ReservationDetailService(IRepository<ReservationDetail> reservationDetailRepository)
        {
            this.reservationDetailRepository = reservationDetailRepository;
        }

        public ReservationDetail GetReservationDetail(Guid id)
        {
            return this.reservationDetailRepository.Get(id);
        }
    }
}
