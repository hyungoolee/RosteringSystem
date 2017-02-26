using Microsoft.VisualStudio.TestTools.UnitTesting;
using RosteringSystem.Models;
using System.Collections.Generic;

namespace RosteringSystem.Tests
{
    [TestClass()]
    public class RepositoryTests
    {
        [TestMethod()]
        public void StaffListTest()
        {
            var repository = new Repository(new RosterContext());
            Assert.Equals(repository.StaffList(), new List<Staff>
            {
                new Staff {FirstName = "Carson", LastName = "Chan", RoleId = 1},
                new Staff {FirstName = "James", LastName = "Lim", RoleId = 1},
                new Staff {FirstName = "Dylan", LastName = "Tong", RoleId = 1},
                new Staff {FirstName = "Cameo", LastName = "Ahn", RoleId = 2},
                new Staff {FirstName = "Mickey", LastName = "Rabbitts", RoleId = 2},
                new Staff {FirstName = "Young", LastName = "Alexander", RoleId = 2},
                new Staff {FirstName = "Hnery", LastName = "Kim", RoleId = 3},
                new Staff {FirstName = "Carl", LastName = "Hong", RoleId = 3},
                new Staff {FirstName = "Chuck", LastName = "Lee", RoleId = 3}
            });
        }

        [TestMethod()]
        public void CreateShiftTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateShiftTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveShiftByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetShiftByIdTest()
        {
            Assert.Fail();
        }
    }
}