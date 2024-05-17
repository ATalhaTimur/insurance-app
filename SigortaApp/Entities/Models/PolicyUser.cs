namespace Entities.Models
{
    public class PolicyUser
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public int UsersId { get; set; }

        public DateTime Ownership_start_date { get; set; }
        public DateTime Ownership_end_date { get; set; }

       
    }
}
