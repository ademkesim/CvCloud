using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Apply:IEntity
    {
        public int ApplyID { get; set; }
        public int PersonID { get; set; }
        public int TitleID { get; set; }
        public int DepartmentID { get; set; }
        public int JobAdvertisementID { get; set; }
        public string Detail { get; set; }
        public byte[] Pdf { get; set; }
    }
}
