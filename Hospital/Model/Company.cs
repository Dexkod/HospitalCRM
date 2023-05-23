using HospitalsCRM.Model.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalCRM.Model
{
    public class Company : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }

        // Connection with 
        public ICollection<Clinic> Clinics { get; set; }

        public Company(int id, string companyName, List<Clinic> clinics)
        {
            Id = id;
            CompanyName = companyName;
            Clinics = clinics;
        }

        public Company()
        {
            Clinics = new List<Clinic>();
        }

        public void Add(IEntity entity, ClinicContext context)
        {
            context.Companys.Add((Company)entity);
        }
    }
}
