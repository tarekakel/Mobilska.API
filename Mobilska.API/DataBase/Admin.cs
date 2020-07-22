using System;
using System.Collections.Generic;

namespace Mobilska.API.DataBase
{
    public partial class Admin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string LasName { get; set; }
        public int? Phone { get; set; }
    }
}
