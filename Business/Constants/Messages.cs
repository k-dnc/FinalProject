using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductRemoved = "Ürün silindi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Site güncelleniyor.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError = "Kategorideki ürün adedini aştınız.";
        public static string ProductsUpdated = "Ürün güncellendi.";
        public static string ProductNameAlreadyExists = "Ürün ismi tabloda yer alıyor.";
        public static string CategoryListed = "Kategoriler listelendi.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı oluşturuldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı kaydı bulunmaktadır.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
