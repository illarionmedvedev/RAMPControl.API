using System.Collections.Generic;
using System.Threading.Tasks;
using RAMPControl.API.Models;

namespace RAMPControl.API.Data
{
    public interface IReportRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity)where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}