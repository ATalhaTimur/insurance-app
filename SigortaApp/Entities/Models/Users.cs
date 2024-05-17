namespace Entities.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }       
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        
        public DateTime Created_at { get; set; }
    }
}
