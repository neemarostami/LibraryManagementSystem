using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model.EFCoreMappings
{
    public class ReservationMap
    {
        public ReservationMap(EntityTypeBuilder<Reservation> entityBuilder)
        {
            entityBuilder.HasKey(p => p.ReservationId);
            entityBuilder.HasOne<Member>().WithMany(a => a.Reservations).HasForeignKey(d => d.MemberId);
        }
    }
}
