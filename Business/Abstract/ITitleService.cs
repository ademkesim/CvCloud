﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITitleService
    {
        IResult Add(Title title);

        IResult Update(Title title);

        IResult Delete(Title title);

        IDataResult<List<Title>> GetList();
        IDataResult<List<Title>> GetByDepartment(int getbydepartmentId);
    }
}
