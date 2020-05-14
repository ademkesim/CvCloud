using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class CurriculumVitae:IEntity
    {
        public int CurriculumVitaeId { get; set; }
        public int PersonID { get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz")]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz")]
        [StringLength(20, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Lütfen Doğum Tarihinizi Giriniz")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Lütfen Doğum Yerinizi Giriniz")]
        public string PlaceOfBirth { get; set; }
        [Required(ErrorMessage = "Lütfen Medeni Halinizi Giriniz")]
        public bool MaritalStatus { get; set; }
        [Required(ErrorMessage = "Lütfen Eğitim Durumunuzu Giriniz")]
        public string EducationStatus { get; set; }
       
        [Required(ErrorMessage = "Lütfen Okulunuzun Adını Giriniz")]
        public string School { get; set; }
        [Required(ErrorMessage = "Lütfen Okula Başlangıç Tarihini  Giriniz")]
        [DataType(DataType.Date)]
        public DateTime SchoolStart { get; set; }
        [Required(ErrorMessage = "Lütfen Okul Bitiş Tarihinizi Giriniz")]
        [DataType(DataType.Date)]
        public DateTime SchoolFinish { get; set; }
        [Required(ErrorMessage = "Lütfen Adresinizi  Giriniz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Lütfen Telefon Numarası Giriniz")]
        [DataType(DataType.PhoneNumber)]
        public string MobilTelefonNumber { get; set; }
        [Required(ErrorMessage = "Lütfen E Postanızı Giriniz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [Required(ErrorMessage = "LütfenYabancı Dilinizi Giriniz")]
        public string ForeignLanguage { get; set; }

        [Required(ErrorMessage = "Lütfen Yabancı Dil Seviyenizi Giriniz")]
        public string ForeignLanguageLevel { get; set; }
        [Required(ErrorMessage = "Lütfen Yetkinliklerinizi Giriniz")]
        public string Competences { get; set; }
        [Required(ErrorMessage = "Lütfen Referansınızı Giriniz")]
        public string Reference { get; set; }
        public byte[] CvPdf { get; set; }
    }
}
