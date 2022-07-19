using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service.Interface;

namespace LibraryManagementSystem.Service.Implementation
{
    public class ReservationService : IReservationService
    {
        private IRepository<Reservation> reservationRepository;
        private IRepository<ReservationDetail> reservationDetailRepository;

        public ReservationService(IRepository<Reservation> reservationRepository, 
            IRepository<ReservationDetail> reservationDetailRepository)
        {
            this.reservationRepository = reservationRepository;
            this.reservationDetailRepository = reservationDetailRepository;
        }

        public Reservation GetReservation(Guid id)
        {
            return this.reservationRepository.Get(id);
        }

        public IEnumerable<Reservation> GetReservations()
        {
            return this.reservationRepository.GetAll();
        }
    }
}
