using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model
{
    public class Reservation : BaseEntity
    {
        public int ReservationId { get; set; }
        public DateTime ReservationDateTime { get; set; }
        public int MemberId { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
