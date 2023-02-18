
using HospitalCRM.Model;
using HospitalsCRM.Model.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalsCRM.Data
{
    public interface IBaseRepository
    {
        Task SaveChangesAsync();
        Task<IEnumerable<Cheque>> GetCheques();
        Task<IEnumerable<Company>> GetCompanys();
        Task<IEnumerable<Clinic>> GetHospitals();
        Task<IEnumerable<Office>> GetOffices();
        Task<IEnumerable<Person>> GetPersons();
        Task<IEnumerable<Service>> GetServices();
        Task Add(IEntity entity);
        Task Delete(IEntity entity);
        Task Update(IEntity entity);
    }
}
