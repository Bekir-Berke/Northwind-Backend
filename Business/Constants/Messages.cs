using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductListed="Ürünler Listelendi";
        public static string MaintenanceTime="Sistem Bakımda";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenemiyor";
        public static string AuthorizationDenied ="Yetkiniz yok";
        public static string AccessTokenCreated;
        public static string UserAlreadyExists;
        public static string SuccessfulLogin;
        public static string UserNotFound;
        public static string PasswordError;
        public static string UserRegistered;
        public static string ProductsListed;
    }
}
