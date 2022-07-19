using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model.EFCoreMappings
{
    public class ReservationDetailMap
    {
        public ReservationDetailMap(EntityTypeBuilder<ReservationDetail> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ReservationDetailId);
            entityBuilder.HasOne<Reservation>().WithMany(a => a.ReservationDetails).HasForeignKey(d => d.ReservationId);
            entityBuilder.HasOne<Book>().WithMany(a => a.ReservationDetails).HasForeignKey(d => d.BookId);
        }
    }
}
