using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models.Auth
{
    public class LibraryUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(userRole))]
        public int UserRoleId { get; set; }
        public UserRole userRole { get; set; }
    }
}
