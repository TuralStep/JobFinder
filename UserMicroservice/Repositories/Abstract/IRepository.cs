﻿namespace UserMicroservice.Repositories.Abstract;

public interface IRepository<T> where T : class
{
    Task<List<T>> GetAll();
    Task<T> GetById(int id);

    Task Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}
