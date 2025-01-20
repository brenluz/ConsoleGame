using Entities;

namespace Repositories;

public abstract class BaseRepository<T> : IRepository<T> where T : class, IIdentifiable
{
    protected abstract IList<T> Items { get;}

    public T Get(int id)
    {
        return Items.Where(x => x.Id == id).FirstOrDefault();
    }
    
    public IList<T> GetAll()
    {
        return Items;
    }

    public int Save(T entity, bool allowUpdate = true)
    {
        var existing = Get(entity.Id);
        if (entity.Id > 0)
        {
            if (allowUpdate)
            {
                Items[Items.IndexOf(existing)] = entity;
            }

            return -1;
        }
        entity.Id = Items.OrderBy(x => x.Id).Last().Id + 1;  
        Items.Add(entity);
        return entity.Id;
    }
}