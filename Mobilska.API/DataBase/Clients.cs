using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Clients
    {
        public Clients()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Mobile { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
