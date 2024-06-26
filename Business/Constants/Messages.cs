﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added";
        public static string ProductDeleted = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";
        public static string ProductNameInvalid = "Product name is invalid";
        public static string MaintenanceTime = "System under maintenance";
        public static string ProductsListed = "Products listed";
        public static string ProductCountOfCategoryError = "There can be a maximum of 10 products in a category";
        public static string ProductNameAlreadyExists = "Another product with this name already exists";
        public static string CategoryLimitExceeded = "New product cannot be added because the category limit has been exceeded";

        public static string AuthorizationDenied = "You do not have authorization";
        public static string UserAdded = "User added";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "User successfully registered";
        public static string AccessTokenCreated = "Access token successfully created";
    }
}
