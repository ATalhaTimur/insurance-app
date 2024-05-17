namespace Entities.Models
{
    public class Transactions
    {
        public int Id { get; set; }
        public int PolicyId { get; set; }
        public int UsersId { get; set; }
        public float TransactionPrice { get; set; }
        public string TransactionType { get; set; }
        public DateTime timestamp { get; set; }
    }
}
