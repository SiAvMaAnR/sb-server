using System.Linq.Expressions;
using MessengerX.Domain.Entities;

namespace MessengerX.Domain.Specification;

public interface ISingleSpecification<TEntity>
    where TEntity : BaseEntity
{
    Expression<Func<TEntity, bool>>? Criteria { get; }
    ICollection<Expression<Func<TEntity, object>>> Includes { get; }
    ICollection<string> IncludeStrings { get; }
    bool IsAsNoTracking { get; }
}

public interface ISpecification<TEntity> : ISingleSpecification<TEntity>
    where TEntity : BaseEntity
{
    Expression<Func<TEntity, object>>? OrderBy { get; }
    Expression<Func<TEntity, object>>? OrderByDescending { get; }
    Expression<Func<TEntity, object>>? GroupBy { get; }
    int Take { get; }
    int Skip { get; }
    bool IsPagingEnabled { get; }
}
