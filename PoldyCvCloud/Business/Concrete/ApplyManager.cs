using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Entities.Concrete;

namespace Business.Concrete
{
public class ApplyManager:IApplyService
{
    private IApplyDal _applyDal;

    public ApplyManager(IApplyDal applyDal)
    {
        _applyDal = applyDal;
    }

    public IDataResult<List<Apply>> GetList()
        {
            return new SuccesDatResult<List<Apply>>(_applyDal.GetList());
        }

        public IResult Add(Apply apply)
        {
            _applyDal.Add(apply);
            return new SuccesResult(Messages.ApplyAdded);
        }

        public IResult Update(Apply apply)
        {
            _applyDal.Update(apply);
            return new SuccessResult(Messages.ApplyUpdated);
        }

        public IResult Delete(Apply apply)
        {
            _applyDal.Delete(apply);
            return new SuccessResult(Messages.ApplyDeleted);
        }

        public IDataResult<List<Apply>> GetByDepartment(int getbydepartmentId)
        {
            return new SuccessDatResult<Apply>(_applyDal.Get(p => p.DepartmentId == getbydepartmentId));
        }

        public IDataResult<List<Apply>> GetByTitle(int getbytitleId)
        {
            return new SuucesDataResult<Apply>(_applyDal.Get(p => p.TitleId == getbytitleId));
        }
    }
}
