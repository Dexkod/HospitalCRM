﻿using HospitalsCRM.Model.Interface;
using System;
using System.Threading.Tasks;

namespace HospitalCRM.Model
{
    public class Cheque : IEntity
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public DateTime DateTime { get; set; }
        public string Information { get; set; }

        // Connection with Hospital
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }

        // Conection with Person
        public int PersonId { get; set; }
        public Person Person { get; set; }
        
        public void Add(IEntity entity, HospitalContext context) 
        {
            context.Cheques.Add((Cheque)entity);
        }
    }
}
