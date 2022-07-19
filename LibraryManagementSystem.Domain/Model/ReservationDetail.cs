using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model
{
    public class ReservationDetail : BaseEntity
    {
        public int ReservationDetailId { get; set; }
        public int ReservationId { get; set; }
        public int BookId { get; set; }
    }
}
