﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListRepositoryStandard
{
    public interface IRepository<T>
    {
        List<T> SelectAll();

        T SelectById(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
