using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RosteringSystem.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        [TestMethod()]
        public void StaffListTest()
        {
            var repository = new Repository(new RosterContext());
            Console.WriteLine(repository.ShiftList());
            Assert.Equals(true, true);
        }

        [TestMethod()]
        public void CreateStaffTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateStaffTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveStaffByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetStaffByIdTest()
        {
            Assert.Fail();
        }
    }
}