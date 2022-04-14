using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGCP.Core.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int id);
        Task<T> GetByEmail(string email);
        Task<IEnumerable<T>> GetAll();

        void Add(T req);
        void Update(T req);
        void Remove(T req);
    }
}
