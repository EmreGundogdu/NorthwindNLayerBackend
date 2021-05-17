using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Başarıyla Eklendi";
        public static string ProductDeleted = "Ürün Başarıyla Silindi";
        public static string ProductUpdated = "Ürün Başarıyla Güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfullLogin = "Sisteme Giriş Başarılı";
        public static string UserAlreadyExists = "Bu Kullanıcı Emaili Zaten Mevcut";
        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi";

        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
    }
}
