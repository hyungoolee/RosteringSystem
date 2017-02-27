namespace RosteringSystem.Data
{
    public partial class Repository : IRepository
    {
        private readonly RosterContext _context;
        public Repository() {
            _context = new RosterContext();
        }
        public Repository(RosterContext context)
        {
            _context = context;
        }

        
    }
}