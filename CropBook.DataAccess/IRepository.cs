﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CropBook.DataAccess
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get();
        TEntity GetById(int id);
        void Add(TEntity data);
        void Delete(int id);
        void Update(TEntity data);
        void Save();
    }
}
