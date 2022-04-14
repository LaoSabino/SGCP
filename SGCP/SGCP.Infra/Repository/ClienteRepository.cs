using Microsoft.EntityFrameworkCore;
using SGCP.Core;
using SGCP.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCP.Data.Repository
{
    public class ClienteRepository : IRepository<Client>
    {
        protected readonly SGCPContext Db;
        protected readonly DbSet<Client> DbSet;

        public void Add(Client req)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Client req)
        {
            throw new NotImplementedException();
        }

        public void Update(Client req)
        {
            throw new NotImplementedException();
        }
    }
}
