namespace RosteringSystem.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Staff Staff { get; set; }
    }
}