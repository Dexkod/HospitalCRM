using System.Collections.Generic;

namespace HospitalCRM.Model
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        // Connection with 
        public ICollection<Hospital> Hospitals { get; set; }

        public Company()
        {
            Hospitals = new List<Hospital>();
        }
    }
}
