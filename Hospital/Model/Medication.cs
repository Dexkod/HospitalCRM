using HospitalsCRM.Model.Interface;
using System.ComponentModel.DataAnnotations;

namespace HospitalCRM.Model
{
    public class Medication : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewInfo { get; set; }
        public int Pricy { get; set; }
        public int Count { get; set; }
        public string Info { get; set; }

        public Medication(){}
        public Medication(int id, string name, string viewInfo, int pricy, int count, string info, Cheque cheque)
        {
            Id = id;
            Name = name;
            ViewInfo = viewInfo;
            Pricy = pricy;
            Count = count;
            Info = info;
            Cheque = cheque;
        }
        public void Add(IEntity entity, ClinicContext context)
        {
            context.Medications.Add((Medication)entity);
        }

        //Connection with Cheque
        public int? ChequeId { get; set; }
        public Cheque Cheque { get; set; }
    }
}
