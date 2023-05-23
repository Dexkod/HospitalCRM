using HospitalsCRM.Model.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalCRM.Model
{
    public class Clinic : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Clinic(int id, string name, string city, Company company, List<Cheque> cheques, List<Office> offices)
        {
            Id = id;
            Name = name;
            City = city;
            Company = company;
            Cheques = cheques;
            Offices = offices;
        }

        public Clinic()
        {
            Cheques = new List<Cheque>();
            Offices = new List<Office>();
        }

        // Connection with Company
        public int? CompanyId { get; set; }
        public Company Company { get; set; }

        // Connection with Cheque
        public ICollection<Cheque> Cheques { get; set; }

        // Connection with Office
        public ICollection<Office> Offices { get; set; }

        public void Add(IEntity entity, ClinicContext context)
        {
            context.Clinics.Add((Clinic)entity);
        }
    }
}
