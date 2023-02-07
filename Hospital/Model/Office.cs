
using System.Collections.Generic;

namespace HospitalCRM.Model
{
    public class Office
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }

        public Office()
        {
            Services = new List<Service>();
        }

        // Connection with Service
        public ICollection<Service> Services { get; set; }

        // Connection with Hospital
        public int? HospitalId { get; set; }
        public Hospital Hospital { get; set; } 
    }
}
