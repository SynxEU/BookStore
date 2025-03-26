using System.Linq.Expressions;
using BookStore.Domain.Entity.Base;
using Microsoft.EntityFrameworkCore.Query;

namespace BookStore.Domain.Interfaces;

public interface IBaseRepository
{
    Task DeleteAsync<TObject>(TObject genericObject) where TObject : class, IBaseEntity;

    Task<TGenericObject> UpdateAsync<TGenericObject>
    (Expression<Func<SetPropertyCalls<TGenericObject>, SetPropertyCalls<TGenericObject>>> propertiesToUpdate,
        Expression<Func<TGenericObject, bool>> objectQueried) where TGenericObject : class, IBaseEntity;

    Task<TGenericObject?> CreateAsync<TGenericObject>(TGenericObject? genericObject)
        where TGenericObject : class, IBaseEntity;

    IQueryable<TGenericObject> Get<TGenericObject>() where TGenericObject : class;
}