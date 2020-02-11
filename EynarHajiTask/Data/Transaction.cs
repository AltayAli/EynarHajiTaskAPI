using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EynarHajiTask.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
