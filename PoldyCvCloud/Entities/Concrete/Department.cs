using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public class Department:IEntity
    {
        public int DepartmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Needs { get; set; }
    }
}
