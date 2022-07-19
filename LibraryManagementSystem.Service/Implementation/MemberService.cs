using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Repository;
using LibraryManagementSystem.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Service.Implementation
{
    public class MemberService : IMemberService
    {
        private IRepository<Member> memberRepository;
        private IRepository<Reservation> reservationRepository;

        public MemberService(IRepository<Member> memberRepository, 
            IRepository<Reservation> reservationRepository)
        {
            this.memberRepository = memberRepository;
            this.reservationRepository = reservationRepository;
        }

        public Member GetMember(Guid id)
        {
            return memberRepository.Get(id);
        }

        public IEnumerable<Member> GetMembers()
        {
            return memberRepository.GetAll();
        }
    }
}
