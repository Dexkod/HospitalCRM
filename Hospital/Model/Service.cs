using HospitalsCRM.Model.Interface;
using System.ComponentModel.DataAnnotations;

namespace HospitalCRM.Model
{
    public class Service : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Information { get; set; }
        public int Pricy { get; set; }

        public Service(int id, string information, int pricy, Office office)
        {
            Id = id;
            Information = information;
            Pricy = pricy;
            Office = office;
        }
        public Service(){}

        public override string ToString()
        {
            return $"{Information}\n цена: {Pricy}";
        }

        // Connection with Person
        public int? OfficeId { get; set; }
        public Office Office { get; set; }
        public void Add(IEntity entity, ClinicContext context)
        {
            context.Services.Add((Service)entity);
        }
    }
}
