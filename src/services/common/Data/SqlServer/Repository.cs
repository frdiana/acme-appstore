using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.AppStore.Common.Data.SqlServer;
public class Repository<TEntity, TKey> :
    ReadonlyRepository<TEntity, TKey> where TEntity : class,
    IEntity<TKey> where TKey : IEquatable<TKey>,
    IRepository<TEntity, TKey>
{
    public Repository(DbContext dbContext) : base(dbContext)
    {
    }
}
