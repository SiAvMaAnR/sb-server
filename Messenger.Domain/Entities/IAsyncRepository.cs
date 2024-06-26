﻿using System.Linq.Expressions;
using MessengerX.Domain.Specification;

namespace MessengerX.Domain.Entities;

public interface IAsyncRepository<TEntity>
    where TEntity : BaseEntity
{
    Task AddAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);

    // Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate);
    // Task<TEntity?> GetAsync(
    //     Expression<Func<TEntity, bool>> predicate,
    //     params Expression<Func<TEntity, object>>[] includeProperties
    // );

    // IEnumerable<TEntity>? GetAll(Expression<Func<TEntity, bool>> predicate);
    // IEnumerable<TEntity>? GetAll();
    // IEnumerable<TEntity>? GetAll(params Expression<Func<TEntity, object>>[] includeProperties);
    // IEnumerable<TEntity>? GetAll(
    //     Expression<Func<TEntity, bool>> predicate,
    //     params Expression<Func<TEntity, object>>[] includeProperties
    // );

    Task<TEntity?> GetAsync(ISingleSpecification<TEntity> specification);
    Task<IEnumerable<TEntity>> GetAllAsync(ISpecification<TEntity>? specification = null);
    Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);
    Task<bool> AllAsync(Expression<Func<TEntity, bool>> predicate);
}
