using DAL.DataCantext;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository.JobService
{
    public class JobRepository : IJobRepository, IDisposable
    {
        private ApplicationDbContext _context;
        private bool disposed = false;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteJob(string id)
            => _context.Jobs.Remove(GetById(id));   

        public IEnumerable<Job> GetAlljob()
            => _context.Jobs.ToList();

        public Job GetById(string Id)
            => _context.Jobs.Find(Id);

        public void InsertJob(Job job)
            => _context.Jobs.Add(job);

        public void Save()
            =>_context.SaveChanges();

        public void UpdateJob(Job job)
            =>_context.Entry(job).State = EntityState.Modified;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
