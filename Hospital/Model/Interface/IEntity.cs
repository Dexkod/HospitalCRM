using HospitalCRM;
using System.Threading.Tasks;

namespace HospitalsCRM.Model.Interface
{
    public interface IEntity
    {
        int Id { get; set; }
        void Add(IEntity entity, HospitalContext context);
    }
}
