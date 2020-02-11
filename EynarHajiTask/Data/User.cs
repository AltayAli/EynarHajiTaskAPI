using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EynarHajiTask.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public User()
        {
            Transactions = new HashSet<Transaction>();
        }
    }
}
