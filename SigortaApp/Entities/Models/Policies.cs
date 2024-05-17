
namespace Entities.Models
{
    public class Policies
    {
        public int Id { get; set; }

        public int UsersId { get; set; }

        public  int PolicyPrice { get; set; }
        public string PolicyType { get; set; }
        public string Coverage { get; set; }

        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public DateTime Created_at { get; set; }


    }
}
