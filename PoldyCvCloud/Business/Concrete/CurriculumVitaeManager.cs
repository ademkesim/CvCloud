using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;

namespace Business.Concrete
{
    public class CurriculumVitaeManager : ICurriculumVitaeService
    {
        private ICurriculumVitaeDal _curriculumVitaeDal;
        public CurriculumVitaeManager(ICurriculumVitaeDal curriculumVitaeDal)
        {
            _curriculumVitaeDal = curriculumVitaeDal;
        }
        string medenidurum;
        public byte[] CvPdf;
        public void CvAdd(CurriculumVitae curriculumVitae)
        {
            Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(@"C:\Users\ademk\Desktop\PoldyMyCv.pdf", FileMode.Create));
            BaseFont arial = BaseFont.CreateFont("c:\\windows\\fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(arial, 12, Font.NORMAL);
            if (document.IsOpen() == false)
            {

                document.Open();

                // iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\ademk\source\repos\Poldy4\deneme\PoldyCv\vesikalik.jpg");
                // img.ScalePercent(30f, 20f);
                string text;

                if (curriculumVitae.MaritalStatus.ToString() == "False")
                {
                    this.medenidurum = "Bekar";
                }
                else if (curriculumVitae.MaritalStatus.ToString() == "True")
                {
                    this.medenidurum = "Evli";
                }
                text =
                    "Kişisel Bilgiler \n" +
                    "--------------------" +
                    "\n Ad :" + curriculumVitae.FirstName +
                    "\n Soyad : " + curriculumVitae.LastName +
                    "\n Doğum Tarihi : " + curriculumVitae.BirthDate +
                    "\n Doğum Yeri : " + curriculumVitae.PlaceOfBirth +
                    "\n Medeni Durum : " + this.medenidurum +
                    "\n ----------------------------------------" +
                    "\n Eğitim Bilgileri" +
                    "\n--------------------" +
                    "\n Öğrenim Seviyesi :" + curriculumVitae.EducationStatus +
                    "\n Okul Adı : " + curriculumVitae.School +
                    "\n Okul Başlangıç : " + curriculumVitae.SchoolStart +
                    "\n Okul Bitiş : " + curriculumVitae.SchoolFinish +
                    "\n --------------------" +
                    "\n İletişim Bilgileri" +
                    "\n ---------------------" +
                    "\n Cep Numarası : " + curriculumVitae.MobilTelefonNumber +
                    "\n Mail Adresi : " + curriculumVitae.Mail +
                    "\n Adres : " + curriculumVitae.Address +
                    "\n --------------------" +
                    "\n Yabancı Dil Bilgileri" +
                    "\n ---------------------" +
                    "\n Yabancı Dil : " + curriculumVitae.ForeignLanguage +
                    "\n Yabancı Dil Seviye : " + curriculumVitae.ForeignLanguageLevel +
                    "\n --------------------" +
                    "\n Yabancı Dil Bilgileri" +
                    "\n ---------------------" +
                    "\n Yetkinlikler : " + curriculumVitae.Competences +
                    "\n ----------------------------" +
                    "\n Referanslar : " + curriculumVitae.Reference
                              ;
                //document.Add(img);

                text = Turkish1.TurkishCharacter(text);
                document.Add(new Paragraph(text, font));
                document.Close();
                this.CvPdf = File.ReadAllBytes(@"C:\Users\ademk\Desktop\PoldyMyCv.pdf");
            }
        }
        public IResult Add(CurriculumVitae curriculumVitae, int id)
        {
            _curriculumVitaeDal.Add(curriculumVitae);
            CvAdd(curriculumVitae);
            int Id = curriculumVitae.CurriculumVitaeId;
            var CV = new CurriculumVitae
            {
                CurriculumVitaeId = curriculumVitae.CurriculumVitaeId,
                PersonID = id,
                FirstName = curriculumVitae.FirstName,
                LastName = curriculumVitae.LastName,
                BirthDate = curriculumVitae.BirthDate,
                PlaceOfBirth = curriculumVitae.PlaceOfBirth,
                MaritalStatus = curriculumVitae.MaritalStatus,
                EducationStatus = curriculumVitae.EducationStatus,
                School = curriculumVitae.School,
                SchoolStart = curriculumVitae.SchoolStart,
                SchoolFinish = curriculumVitae.SchoolFinish,
                Address = curriculumVitae.Address,
                MobilTelefonNumber = curriculumVitae.MobilTelefonNumber,
                Mail = curriculumVitae.Mail,
                ForeignLanguage = curriculumVitae.ForeignLanguage,
                ForeignLanguageLevel = curriculumVitae.ForeignLanguageLevel,
                Competences = curriculumVitae.Competences,
                Reference = curriculumVitae.Reference,
                CvPdf = this.CvPdf
            };
            _curriculumVitaeDal.Update(CV);
            return new SuccessResult(Messages.CurriculumVitaeAdded);
        }

        public IResult Update(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Update(curriculumVitae);
            return new SuccessResult(Messages.CurriculumVitaeUpdated);
        }


        public IResult Delete(CurriculumVitae curriculumVitae)
        {
            _curriculumVitaeDal.Delete(curriculumVitae);
            return new SuccessResult(Messages.CurriculumVitaeDeleted);
        }

        public IDataResult<CurriculumVitae> GetById(int id)
        {
            return new SuccessDataResult<CurriculumVitae>(_curriculumVitaeDal.Get(p=>p.PersonID == id));
        }
    }
}
