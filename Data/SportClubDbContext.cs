using SportClubApi.Models;
using Microsoft.EntityFrameworkCore;

namespace SportClubApi.Data
{
    public class SportClubDbContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Administration> Administrations { get; set; }
        
        public DbSet<Role> Roles { get; set; }

        public SportClubDbContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add Rooms
            modelBuilder.Entity<Room>()
                .HasData(new List<Room>
            {
                new() { Id = 1, Name = "Small gym first floor", MaxCountPeoples = 10 },
                new() { Id = 2, Name = "Small gym second floor", MaxCountPeoples = 10 },
                new() { Id = 3, Name = "Big gym second floor", MaxCountPeoples = 30 }
            });

            // Add Roles
            modelBuilder.Entity<Role>()
                 .HasData(new List<Role>
            {
                new() { Id = 1, Name = "User" },
                new() { Id = 2, Name = "Coach" },
                new() { Id = 3, Name = "ChiefCoach" },
                new() { Id = 4, Name = "SeniorCoach" },
                new() { Id = 5, Name = "Manager" },
                new() { Id = 6, Name = "ChiefManager" }
            });

            // Add Clients
            modelBuilder.Entity<Client>()
                .HasData(new List<Client>
            {
                new() { Id = 1, Name = "Melyssa ", Surname = "Chapma", Birthday = new DateTime(),
                    Phone = "1-741-854-436", Email = "turpis.egestas@yahoo.org", Gender = "Woman", 
                    RoleId = 1, Login = "melyssa3", Password = "12345678"},

                new() { Id = 2, Name = "Adele", Surname = "Bond", Birthday = new DateTime(),
                    Phone = "1-555-939-409", Email = "iaculis.odio@outlook.net", Gender = "Man", 
                    RoleId = 1, Login = "adele2", Password = "12345677"},

                new() { Id = 3, Name = "Clementine", Surname = "Barron", Birthday = new DateTime(),
                    Phone = "(519) 440-6692", Email = "cras.dictum@yahoo.com", Gender = "Man", 
                    RoleId = 1, Login = "barron84", Password = "12345688"}
            });

            // Add Coaches
            modelBuilder.Entity<Coach>()
                .HasData(new List<Coach>
            {
                new() { Id = 1, Name = "Zoe", Surname = "Lawrence", Specialization = "Dance", Birthday = new DateTime(),
                    Phone = "1-726-649-8019", Email = "libero@protonmail.com", Gender = "Woman",
                    RoleId = 2, Login = "zoe324", Password = "12345678"},

                new() { Id = 2, Name = "Sonia", Surname = "Pace", Specialization = "Fitness", Birthday = new DateTime(),
                    Phone = "1-483-371-8688", Email = "vitae.nibh.donec@aol.org", Gender = "Woman",
                    RoleId = 3, Login = "sonia2", Password = "12345677"},

                new() { Id = 3, Name = "Tanish", Surname = "Wilkerson", 
                    Specialization = "Weightlifting", Birthday = new DateTime(),
                    Phone = "1-631-822-9587", Email = "est@icloud.net", Gender = "Man",
                    RoleId = 4, Login = "tanish33", Password = "12345688"}
            });

            // Add Administation    
            modelBuilder.Entity<Administration>()
                .HasData(new List<Administration>
            {
                new() { Id = 1, Name = "Tucker", Surname = "Harrington", Birthday = new DateTime(),
                    Phone = "(958) 545-6274", Email = "ut.lacus@icloud.ca", Gender = "Man",
                    RoleId = 5, Login = "tuckertuc", Password = "12345678"},

                new() { Id = 2, Name = "Serina", Surname = "Holland", Birthday = new DateTime(),
                    Phone = "(566) 496-7373", Email = "nulla.cras@protonmail.com", Gender = "Woman",
                    RoleId = 6, Login = "serinaq", Password = "12345677"},
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
