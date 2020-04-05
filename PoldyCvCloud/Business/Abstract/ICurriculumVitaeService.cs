using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICurriculumVitaeService
  {
      IResult Add(CurriculumVitae curriculumvitae);

      IResult Update(CurriculumVitae curriculumvitae);

      IResult Delete(CurriculumVitae curriculumvitae);
    }
}
