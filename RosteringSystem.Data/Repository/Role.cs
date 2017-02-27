using RosteringSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public List<Role> RoleList() => _context.Roles.ToList();

        public void CreateRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public bool UpdateRole(Role role)
        {
            var found = _context.Jobs.Find(role.Id);
            if (found == null) return false;

            _context.Entry(found).CurrentValues.SetValues(role);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveRoleById(int id)
        {
            var found = _context.Roles.Find(id);
            if (found == null) return false;

            _context.Roles.Remove(found);
            _context.SaveChanges();
            return true;
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Find(id);
        }
    }
}
