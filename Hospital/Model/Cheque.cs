using System;

namespace HospitalCRM.Model
{
    public class Cheque
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public DateTime DateTime { get; set; }
        public string Information { get; set; }

        // Connection with Hospital
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }

        // Conection with Person
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
