using RosteringSystem.Models;

namespace RosteringSystem
{
    public partial class Repository : IRepository
    {
        private RosterContext _context;

        public Repository(RosterContext context)
        {
            _context = context;
        }
    }
}