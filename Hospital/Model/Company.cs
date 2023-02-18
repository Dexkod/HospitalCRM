using HospitalsCRM.Model.Interface;
using System.Collections.Generic;

namespace HospitalCRM.Model
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        // Connection with 
        public ICollection<Clinic> Clinics { get; set; }

        public Company()
        {
            Clinics = new List<Clinic>();
        }

        public void Add(IEntity entity, HospitalContext context)
        {
            context.Companys.Add((Company)entity);
        }
    }
}
