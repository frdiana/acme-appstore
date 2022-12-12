namespace Acme.AppStore.Common.Data.SqlServer;
    public interface IRepository<TEntity, TKey> : IReadonlyRepository<TEntity, TKey> where TEntity : class, IEntity<TKey> where TKey : IEquatable<TKey>
    {



    }

