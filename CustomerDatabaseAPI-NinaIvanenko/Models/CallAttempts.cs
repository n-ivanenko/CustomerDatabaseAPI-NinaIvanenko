using System;

namespace customer_database_API_Nina.Models
{
    public class CallAttempt
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime AttemptDate { get; set; }
        public string Notes { get; set; }
    }
}