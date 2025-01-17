﻿

using TodoListManagement.Models;

namespace TodoListManagement.Repository;

public interface IRepository <TEntity , TId>
    where TEntity : Entity<TId>, new()
{
    List<TEntity> GetAll();
    TEntity? GetById(TId id);

    TEntity Add(TEntity item);
    TEntity? Update(TEntity item);
    TEntity? Delete(TId id);
}
