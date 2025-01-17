﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessment.Registration.Application.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
    }
}
