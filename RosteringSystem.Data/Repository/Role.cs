using RosteringSystem.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace RosteringSystem.Data
{
    public partial class Repository
    {
        public List<Role> RoleList()
        {
            return _context.Roles.ToList();
        }
        
        public void CreateRole(Role Role)
        {
            _context.Roles.Add(Role);
            _context.SaveChanges();
        }

        public bool UpdateRole(Role Role)
        {
            var found = _context.Roles.Find(Role.Id);
            if (found == null) return false;

            _context.Entry(found).CurrentValues.SetValues(Role);
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