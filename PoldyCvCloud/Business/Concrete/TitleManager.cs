using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TitleManager : ITitleService
    {
        private ITitleDal _titleDal;

        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }

        public IResult Add(Title title)
        {
            _titleDal.Add(title);
            return new SuccessResult(Message.TitleAdded);
        }

        public IResult Delete(Title title)
        {
            _titleDal.Delete(title);
            return new SuccessResult(Message.TitleDeleted);
        }

        public IDataResult<List<Title>> GetByDepartment(int getbydepartmentId)
        {
            return new SuccessDataResult<List<Title>>(_titleDal.Get(p=>p.DepartmentId=getbydepartmentId));
        }

        public IDataResult<List<Title>> GetList()
        {
            return new SuccessDataResult<List<Title>>(_titleDal.GetList());
        }

        public IResult Update(Title title)
        {
            _titleDal.Update(title);
            return new SuccessResult(Message.TitleUpdated);
        }
    }
}
