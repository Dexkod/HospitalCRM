using HospitalCRM;
using HospitalCRM.Model;
using HospitalsCRM.Model.Interface;

namespace Hospital
{
    public class Medication : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ViewInfo { get; set; }
        public int Pricy { get; set; }
        public int Count { get; set; }
        public string Info { get; set; }

        public Medication(){}
        public Medication(int id, string name, string viewInfo, int pricy, int count, string info)
        {
            Id = id;
            Name = name;
            ViewInfo = viewInfo;
            Pricy = pricy;
            Count = count;
            Info = info;
            //ChequeId = 1;
            //Cheque = default;
        }
        public void Add(IEntity entity, HospitalContext context)
        {
            context.Medications.Add((Medication)entity);
        }

        // Connection with Card

        //public int ChequeId { get; set; }
        //public Cheque Cheque { get; set; }
    }
}
