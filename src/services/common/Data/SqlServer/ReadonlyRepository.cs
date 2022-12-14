using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.AppStore.Common.Data.SqlServer
{
    public class ReadonlyRepository<TEntity, TKey> :
        IReadonlyRepository<TEntity, TKey> where TEntity : class,
        IEntity<TKey> where TKey : IEquatable<TKey>
    {
        private readonly DbContext dbContext;

        public ReadonlyRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(TKey id)
        {
            throw new NotImplementedException();
        }
    }
}
