﻿using System.Linq.Expressions;

namespace InkEchoes.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        Task<T?> GetAsync(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false);
        Task AddAsync(T entity);
        void Remove(T entity);
    }
}
