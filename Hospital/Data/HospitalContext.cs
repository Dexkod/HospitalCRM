
using HospitalCRM.Model;
using System.Data.Entity;

namespace HospitalCRM
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base ("HospitalContext") { }

        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
