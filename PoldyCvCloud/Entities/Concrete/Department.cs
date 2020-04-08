using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Department:IEntity
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Needs { get; set; }
    }
}
