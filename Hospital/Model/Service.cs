using HospitalsCRM.Model.Interface;

namespace HospitalCRM.Model
{
    public class Service : IEntity
    {
        public int Id { get; set; }
        public string Information { get; set; }
        public int Pricy { get; set; }

        public override string ToString()
        {
            return $"{Information}\n цена: {Pricy}";
        }

        // Connection with Person
        public int? OfficeId { get; set; }
        public Office Office { get; set; }
        public void Add(IEntity entity, HospitalContext context)
        {
            context.Services.Add((Service)entity);
        }
    }
}
