using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Business.Abstract;
using Business.Constans;
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
           return SuccessResult(Messages.CvAdded);
       }

        public IResult Update(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Update(curriculumVitae);
            return SuccesResult(Messages.CvUpdated);
        }

        public IResult Delete(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Delete(curriculumVitae);
            return SuccessResult(Messages.CvDeleted);
        }
    }
}
