using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Title:IEntity
    {
        public int TitleId { get; set; }
        public int DepartmentId { get; set; }
        public string TitleName { get; set; }

    }
}
