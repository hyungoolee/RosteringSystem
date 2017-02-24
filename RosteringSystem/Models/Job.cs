namespace RosteringSystem.Models
{
    public class Job
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Customer Customer { get; set; }
    }
}