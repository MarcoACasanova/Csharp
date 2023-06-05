using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevJobs.API.entities;

namespace DevJobs.API.Persistence
{
    public class DevJobsContext
    {
        public DevJobsContext()
        {
           JobVacancies = new List<JobVacancy>(); 
        }
        public List<JobVacancy> JobVacancies {get; set;}
    }    
}