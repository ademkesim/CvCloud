using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICurriculumVitaeService
    {
        IResult Add(CurriculumVitae curriculumVitae);
        IResult Update(CurriculumVitae curriculumVitae);
        IResult Delete(CurriculumVitae curriculumVitae);
    }
}
