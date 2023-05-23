
using HospitalsCRM.Model.Interface;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalCRM.Model
{
    public class Office : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public Office(int id, int number, string name, List<Service> services, Clinic clinic)
        {
            Id = id;
            Number = number;
            Name = name;
            Services = services;
            Clinic = clinic;
        }
        public Office()
        {
            Services = new List<Service>();
        }

        // Connection with Service
        public ICollection<Service> Services { get; set; }

        // Connection with Clinic
        public int? ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        public void Add(IEntity entity, ClinicContext context)
        {
            context.Offices.Add((Office)entity);
        }
    }
}
