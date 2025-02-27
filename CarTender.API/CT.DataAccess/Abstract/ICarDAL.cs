﻿using CT.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CT.DataAccess.Abstract
{
    public interface ICarDAL
    {
        List<Car> GetAll(Expression<Func<Car, bool>> filter = null);
        Car Get(Expression<Func<User, bool>> filter);
        bool Add(Car entity);
        bool Update(Car entity);
        bool Delete(Car entity);
    }
}
