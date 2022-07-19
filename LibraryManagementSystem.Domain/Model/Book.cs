using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public string? AuthorName { get; set; }
        public virtual ICollection<ReservationDetail> ReservationDetails { get; set; }
    }
}
