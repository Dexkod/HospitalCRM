
using System.Collections;
using System.Collections.Generic;

namespace HospitalCRM.Model
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get;set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }

        public Person()
        {
            Cheques = new List<Cheque>();
        }
        
        // Connection with 
        public ICollection<Cheque> Cheques { get; set; }

    }
}
