using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
   public class Title:IEntity
    {
        public int TitleId { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        public string TitleName { get; set; }
    }
}
