using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Auth
{

        public class UserRole
        {
            public int Id { get; set; }
            public string role { get; set; } // role : staff, member

            public ICollection<LibraryUser> users { get; set; } = new List<LibraryUser>();
        }
    
}
