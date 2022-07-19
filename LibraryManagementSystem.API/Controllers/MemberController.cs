using LibraryManagementSystem.Domain.Model;
using LibraryManagementSystem.Service.Implementation;
using LibraryManagementSystem.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService memberService;

        public MemberController(IMemberService MemberService)
        {
            this.memberService = MemberService;
        }

        [HttpGet]
        [Route("List")]
        public List<Member> GetMembersList()
        {
            List<Member> Members = new List<Member>();
            return memberService.GetMembers().ToList();

        }

        [HttpGet]
        [Route("HistoryOfBookReservations")]
        public dynamic GetMemberBooksList(int id)
        {
            List<Member> Members = new List<Member>();
            return memberService.GetMembers().ToList();

        }
    }
}
