using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Model.EFCoreMappings
{
    public class MemberMap
    {
        public MemberMap(EntityTypeBuilder<Member> entityBuilder)
        {
            entityBuilder.HasKey(p => p.MemberId);
        }
    }
}
