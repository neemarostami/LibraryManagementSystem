using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Service.Implementation;
using LibraryManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;
        private readonly IReservationDetailService reservationDetailService;

        public ReservationController(IReservationService reservationService, IReservationDetailService reservationDetailService)
        {
            this.reservationService = reservationService;
            this.reservationDetailService = reservationDetailService;
        }

        [HttpGet]
        [Route("{id:int}")]
        public Reservation GetReservationsById(Guid id)
        {
            List<Reservation> Reservations = new List<Reservation>();
            return reservationService.GetReservation(id);
        }

        [HttpGet]
        [Route("List")]
        public List<Reservation> GetReservationsList()
        {
            List<Reservation> Reservations = new List<Reservation>();
            return reservationService.GetReservations().ToList();
        }

        [HttpGet]
        [Route("DetailList")]
        public ReservationDetail GetReservationDetailsList(Guid id)
        {
            List<ReservationDetail> reservationsDetail = new List<ReservationDetail>();
            return reservationDetailService.GetReservationDetail(id);
        }
    }
}
