using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ProgSolutions
{
    /*public class MigrationsContextFactory : IDbContextFactory<MarathonContext>
    {
        public MarathonContext Create()
        {
            return new MarathonContext();
        }
    }*/
    public class MarathonContext: DbContext
    {
        public MarathonContext()
            : base("name=Student6") 
        {
            Database.SetInitializer<MarathonContext>(new CreateDatabaseIfNotExists<MarathonContext>());
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Runner> Runners { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<RaceKitOption> RaceKitOptions { get; set; }
        public DbSet<RegistrationStatus> RegistrationStatuses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Sponsorship> Sponsorships { get; set; }
        public DbSet<Marathon> Marathons { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<RegistrationEvent> RegistrationEvents { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
    }
}
