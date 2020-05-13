using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICurriculumVitaeService
    {
        void CvAdd(CurriculumVitae curriculumVitae);
        IResult Add(CurriculumVitae curriculumVitae, int id);
        IResult Update(CurriculumVitae curriculumVitae);
        IResult Delete(CurriculumVitae curriculumVitae);
        IDataResult<CurriculumVitae> GetById(int id);
    }
}
