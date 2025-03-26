using BookStore.Domain.Entity.Base;
using BookStore.Domain.Interfaces;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace BookStore.Domain.Repository;

public abstract class BaseRepository : IBaseRepository
{
    protected readonly BookStoreContext _context;
    public BaseRepository(BookStoreContext context)
    {
        _context = context;
    }
    public IQueryable<TGenericObject> Get<TGenericObject>() where TGenericObject : class => _context.Set<TGenericObject>();
    
    
    public async Task<TGenericObject?> CreateAsync<TGenericObject>(TGenericObject? genericObject)
        where TGenericObject : class, IBaseEntity
    {
        if (genericObject == null) return null;
        var entityEntry =  await _context.AddAsync(genericObject);
        await _context.SaveChangesAsync();
        return entityEntry.Entity;
       
    }
    public virtual async Task<TGenericObject> UpdateAsync<TGenericObject>
    (Expression<Func<SetPropertyCalls<TGenericObject>, SetPropertyCalls<TGenericObject>>> propertiesToUpdate,
        Expression<Func<TGenericObject, bool>> objectQueried) where TGenericObject : class, IBaseEntity
    {
        try
        {
           var objectToReturn = Get<TGenericObject>();
           await objectToReturn.Where(objectQueried).ExecuteUpdateAsync(propertiesToUpdate);
           return await objectToReturn.FirstAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught in UpdateAsync");
            Console.WriteLine(e);
            
        }
        return null;
    }
    public virtual async Task DeleteAsync<TObject>(TObject genericObject) where TObject: class, IBaseEntity
    {
        DbSet<TObject> dbSet = _context.Set<TObject>();
        if (!dbSet.Any(g => g.Id == genericObject.Id)){ }
        await dbSet.Where(x=>x.Id == genericObject.Id).ExecuteDeleteAsync();
    }
}