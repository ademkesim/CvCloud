using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

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
           return new SuccessResult(Message.CurriculumVitaeAdded);
       }

        public IResult Update(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Update(curriculumVitae);
            return new SuccesResult(Message.CurriculumVitaeUpdated);
        }


        public IResult Delete(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Delete(curriculumVitae);
            return new SuccessResult(Message.curriculumVitaeDeleted);
        }
    }
}
