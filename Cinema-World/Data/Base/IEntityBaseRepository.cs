﻿using Cinema_World.Models;

namespace Cinema_World.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIDAsync(int ID);
        Task AddAsync(T entity);
        Task UpdateAsync(int ID, T entity);
        Task DeleteAsync(int ID);
    }
}
