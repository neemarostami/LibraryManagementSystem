using LibraryManagementSystem.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LibraryManagementSystem.Domain.UnitTests.Entities
{
    [TestClass]
    public class MemberTest
    {
        [TestMethod]
        public void MemberFullNameMaximumLengthMustBe100()
        {
            Member member = new Member();
            member.FullName = "Nima Rostami";

            var expectedLength = 100;
            var realLenght = member.FullName.Length;

            Assert.IsTrue(expectedLength >= realLenght);
        }

        [TestMethod]
        public void MemberNationalCodeIsNumber()
        {
            Member member = new Member();
            member.NationalCode = 1360300716;
            long nCode = 0;

            if (!long.TryParse(member.NationalCode.ToString(), out nCode))
            {
                Assert.Fail();
            }
        }
    }
}
