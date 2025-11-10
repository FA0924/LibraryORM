using Library.Context;
using Library.Models.Auth;
using Library.Models.Enum;

namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicatinDbContext())
            {
                // Seed initial data
                var staffRole = new UserRole { role = "Staff" };
                var memberRole = new UserRole { role = "Member" };

                var user1 = new LibraryUser
                {
                    Name = "Ahmed",
                    Email = "ahmed@library.com",
                    Password = "123456",
                    userRole = staffRole
                };

                var user2 = new LibraryUser
                {
                    Name = "Fatma",
                    Email = "fatma@library.com",
                    Password = "123456",
                    userRole = memberRole
                };

                context.AddRange(staffRole, memberRole, user1, user2);
                context.SaveChanges();
            }

            using (var context = new ApplicatinDbContext())
            {
                Console.WriteLine("Welcome to the Library Management System\n");

                Console.WriteLine("User Roles");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"{"ID",-3} {"Role",-20}");
                Console.WriteLine("------------------------------------------------------------");

                var roles = context.UserRoles
                    .Select(r => new
                    {
                        r.Id,
                        r.role
                    })
                    .ToList();

                foreach (var r in roles)
                {
                    Console.WriteLine($"{r.Id,-3} {r.role,-20}");
                }

                Console.WriteLine("\nLibrary Users");
                Console.WriteLine("-------------------------------------------------------------------------------------");
                Console.WriteLine($"{"ID",-3} {"Name",-20} {"Email",-30} {"Role",-15}");
                Console.WriteLine("-------------------------------------------------------------------------------------");

                var users = context.users
                    .Select(u => new
                    {
                        u.Id,
                        u.Name,
                        u.Email,
                        Role = u.userRole.role
                    })
                    .ToList();

                foreach (var u in users)
                {
                    Console.WriteLine($"{u.Id,-3} {u.Name,-20} {u.Email,-30} {u.Role,-15}");
                }

                Console.WriteLine("\nDisplay completed successfully.");
            }
        }
    }
}