namespace Acme.AppStore.Common.Data.SqlServer;

public interface IReadonlyRepository<TEntity, TKey> where TEntity : class, IEntity<TKey> where TKey : IEquatable<TKey>
{
    IEnumerable<TEntity> GetAll();
    TEntity GetById(TKey id);
}

