﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities.Concrte;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IPersonDal:IEntityRepository<Person>
    {
    }
}
