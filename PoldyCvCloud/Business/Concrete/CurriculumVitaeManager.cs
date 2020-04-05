using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Business.Abstract;

namespace Business.Concrete
{
   public class CurriculumVitaeManager:ICurriculumVitaeService
   {
       private ICurriculumVitaeDal _curriculumVitaeDal;

       public CurriculumVitaeManager(ICurriculumVitaeDal curriculumVitaeDal)
       {
           _curriculumVitaeDal = curriculumVitaeDal;
       }

       public IResult Add(CurriculumVitae curriculumVitae)
       {
           _curriculumVitaeDal.Add(curriculumVitae);
           return SuccessResult(Message.Added);
       }

        public IResult Update(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Update(curriculumVitae);
            return SuccesResault(Message.Updated);
        }

        public IResult Delete(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Delete(curriculumVitae);
            return SuccessResult(Message.Deleted);
        }
    }
}
