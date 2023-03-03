

using Hospital;
using HospitalCRM;
using HospitalCRM.Model;
using HospitalsCRM.Data;
using HospitalsCRM.Model.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;

namespace Hospitals.Data
{
    public sealed class Repository : IBaseRepository
    {
        private HospitalContext Dbcontext;
        private static Repository context;
        private Repository(HospitalContext Dbcontext){ this.Dbcontext = Dbcontext; }
        public static Repository Context { 
            get
            {
                if (context == null)
                {
                    context = new Repository(new HospitalContext());
                }
                return context;
            } 
        }



        public Task Delete(IEntity entity)
        {
            throw new System.NotImplementedException();
        }
        public Task Update(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task Add(IEntity entity)
        {
            entity.Add(entity, Dbcontext);
            await Dbcontext.SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await Dbcontext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Cheque>> GetCheques()
        {
            return await Dbcontext.Cheques.ToListAsync();
        }

        public async Task<IEnumerable<Company>> GetCompanys()
        {
            return await Dbcontext.Companys.ToListAsync();
        }

        public async Task<IEnumerable<Clinic>> GetHospitals()
        {
            return await Dbcontext.Clinics.ToListAsync();
        }

        public async Task<IEnumerable<Office>> GetOffices()
        {
            return await Dbcontext.Offices.ToListAsync();
        }
        public async Task<IEnumerable<Medication>> GetMedications()
        {
            return await Dbcontext.Medications.ToListAsync();
        }
        public async Task<IEnumerable<Person>> GetPersons()
        {
            return await Task.Run(() => Dbcontext.Persons.ToListAsync());
        }

        public async Task<IEnumerable<Service>> GetServices()
        {
            return await Dbcontext.Services.ToListAsync();
        }
    }
}
