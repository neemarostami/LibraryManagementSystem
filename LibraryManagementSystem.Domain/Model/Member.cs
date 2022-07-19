using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model
{
    public class Member : BaseEntity
    {
        public int MemberId { get; set; }
        public long NationalCode { get; set; }
        public string? FullName { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
