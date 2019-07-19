﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace TaskThree.DAL.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> filter);
        T Get(string id);
        void Create(T item);
        void Update(T item);
        void Delete(string id);
    }
}
