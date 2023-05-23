
using Hospital;
using HospitalCRM.Model;
using System.Data.Entity;

namespace HospitalCRM
{
    public class ClinicContext : DbContext
    {
        public ClinicContext() : base ("ClinicContext") { }
        public DbSet<Cheque> Cheques { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Medication> Medications { get; set; }
    }
}
