using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {
        public Writer GetByMail(string p/*Expression<Func<Writer, bool>> filter*/)
        {
           


            using var c = new Context();
            return c.Set<Writer>().Where(x=>x.WriterMail==p).FirstOrDefault();
        }
    }
}
