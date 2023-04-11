using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.JobService
{
    public interface IJobRepository : IDisposable
    {
        IEnumerable<Job> GetAlljob();
        Job GetById(string Id);
        void InsertJob(Job job);
        void DeleteJob(string id);
        void UpdateJob(Job job);
        void Save();
    }
}
