using HospitalsCRM.Model.Interface;
using System.Collections.Generic;

namespace HospitalCRM.Model
{
    public class Clinic : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

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

        public void Add(IEntity entity, HospitalContext context)
        {
            context.Clinics.Add((Clinic)entity);
        }
    }
}
