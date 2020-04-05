using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class JobAdvertisement:IEntity
    {
        public int AdvertisementId { get; set; }
        public int DepartmentId { get; set; }
        public int TitleId { get; set; }

    }
}
