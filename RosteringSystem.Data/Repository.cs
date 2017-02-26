namespace RosteringSystem.Data
{
    public partial class Repository : IRepository
    {
        private readonly RosterContext _context;

        public Repository(RosterContext context)
        {
            _context = context;
        }
    }
}