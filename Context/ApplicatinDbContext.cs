using Library.Models.Auth;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Context
{
    public class ApplicatinDbContext  : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            string con = "server = . ; database = LibraryDb ; " +

                "Integrated Security = True ; Encrypt = True ; Trust Server Certificate = True ;";

            optionsBuilder.UseSqlServer(con);

        }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<LibraryUser> users { get; set; }


    }
}
