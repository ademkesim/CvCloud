﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IApplyService
  {
      IDataResult<List<Apply>> GetList();
      IResult Add(Apply apply);

      IResult Update(Apply apply);

      IResult Delete(Apply apply);

      IDataResult<List<Apply>> GetByDepartment(int getbydepartmentId);

      IDataResult<List<Apply>> GetByTitle(int getbytitleId);
      IDataResult<List<Apply>> GetById(int getbyapplyId);
      CurriculumVitae DownloadPdf(int personId);
      void Conformation();

  }
}
