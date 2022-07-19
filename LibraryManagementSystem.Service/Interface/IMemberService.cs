
using LibraryManagementSystem.Domain.Model;

namespace LibraryManagementSystem.Service.Interface
{
    public interface IMemberService
    {
        IEnumerable<Member> GetMembers();
        Member GetMember(Guid id);
    }
}
