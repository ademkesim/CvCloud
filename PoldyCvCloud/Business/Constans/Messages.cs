using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Asn1.Mozilla;

namespace Business.Constans
{
    public static class Messages
    {
        //for Apply
        public static string ApplyAdded = "Başvurunuz başarıyla alındı";
        public static string ApplyUpdated = "Başvurunuz başarıyla  Güncellendi";
        public static string ApplyDeleted = "Başvurunuz silindi";

        //for Curriculum vitae 
        public static string CurriculumVitaeAdded = "Cv'niz Kaydedildi";
        public static string CurriculumVitaeUpdated = "Cv'niz başarıyla  Güncellendi";
        public static string CurriculumVitaeDeleted = "Cv'niz silindi";

        //for Department
        public static string DepartmentAdded = "Departman başarıyla eklendi";
        public static string DepartmentUpdated = "Departman başarıyla  Güncellendi";
        public static string DepartmentDeleted = "Depatman başarıyla silindi";

        //for JobAdvertisement
        public static object JobAdvertisementAdded = "İş ilanı başarıyla oluşturuldu";
        public static string JobAdvertisementUpdated = "İş ilanı başarıyla güncellendi";
        public static string JobAdvertisementDeleted = "İş ilanı başarıyla silindi";
        //for Person
        public static string PersonAdded = "Kişi başarıyla eklendi";
        public static string PersonUpdated ="Kişi başarıyla güncellendi";
        public static string PersonDeleted = "Kişi başarıyla silindi";
        //for Title
        public static string TitleAdded = "Ünvan başarıyla eklendi";
        public static string TitleDeleted = "Ünvan Başarıyla silindi";
        public static string TitleUpdated = "Ünvan başarıyla güncellendi";
        //for Notification
        public static string NotificationAdded = "Bildirim başarıyla eklendi";
        public static string NotificationUpdated = "Bildirim başarıyla güncellendi";
        public static string NotificationDeleted = "Bildirim başarıyla silindi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordEror = "Şifre Hatalı";
        public static string messagesSuccesfulLogin = "Sisteme Başarıyla giriş yapıldı";
        public static string alreadyUserExists = "Bu kullanıcı zaten mevcut";
        public static string userRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Acces Token Başarıyla Oluşturuldu";
        public static string SuccesfulLogin = "Giriş Başarılı";
        public static string DownloadedPdf = "Cv Pdf İndirildi";
    }
}
