using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularFirst.Services
{
    interface IRepository<TEntity>
    {
        public Task<TEntity> GetAsync(Guid? id);
        public Task<IEnumerable<TEntity>> GetAllAsync();
        public Task<bool> Update(TEntity entity);
        public Task<bool> Delete(TEntity entity);
        public Task<dynamic> GetAsJsonAsync(Guid? id);
    }
}
