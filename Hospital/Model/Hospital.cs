using System.Collections.Generic;

namespace HospitalCRM.Model
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Hospital()
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

    }
}
