
using HospitalsCRM.Model.Interface;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HospitalCRM.Model
{
    public class Person : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string LastName { get;set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public string UrlImage { get; set; }
        public bool Administrator { get; set; }

        public Person()
        {
            Cheques = new List<Cheque>();
        }
        
        public Person(string name, string lastName, int age, string login, string password,long phone)
        {
            Name = name;
            Age = age;
            LastName = lastName;
            Login = login;
            Password = password;
            Phone = phone;
            Cheques = new List<Cheque>();
        }
        // Connection with 
        public ICollection<Cheque> Cheques { get; set; }

        public void Add(IEntity entity, ClinicContext context)
        {
            context.Persons.Add((Person)entity);
        }
    }
}
