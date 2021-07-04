using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Graduation_project3.Models
{
    // Models used as parameters to AccountController actions.

    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "External access token")]
        public string ExternalAccessToken { get; set; }
    }

    public class ChangePasswordBindingModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterBindingModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Range(18, 65)]
        public int Age { get; set; }
        public string Birthday { get; set; }

        [Required]
        public string Address { get; set; }
        public BloodType Blood_Type { get; set; }
        [Required]
        public bool Diseases { get; set; }
        [Required]
        public string Medicines { get; set; }
        public string Last_Donation { get; set; }
        public string PhoneNumber { get; set; }
        public string Image_Path { get; set; }
    }

    public class RegisterExternalBindingModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class RemoveLoginBindingModel
    {
        [Required]
        [Display(Name = "Login provider")]
        public string LoginProvider { get; set; }

        [Required]
        [Display(Name = "Provider key")]
        public string ProviderKey { get; set; }
    }

    public class SetPasswordBindingModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
    public class ChangePhoneNOBindingModel
    {
        [StringLength(100, ErrorMessage = "Phone NUmber", MinimumLength = 11)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "New Phone Number")]
        public string NewPhone { get; set; }
    }
    public class ChangeAgeBindingModel
    {

        [Range(18, 65)]
        [Display(Name = "New Age")]
        public int NewAge { get; set; }
    }
    public class ChangeCityBindingModel
    {


        [Display(Name = "New Address")]
        public string NewAddress { get; set; }
    }
    public class ChangeDiseasesBindingModel
    {


        [Display(Name = "New Diseases")]
        public bool NewDiseases { get; set; }
    }
    public class ChangeMedicinesBindingModel
    {


        [Display(Name = "New Medicines")]
        public string NewMedicines { get; set; }
    }
    public class ChangeLast_DonationBindingModel
    {


        [Display(Name = "New Last_Donation")]
        public string NewLast_Donation { get; set; }
    }
    public class ChangeImage_PathBindingModel
    {


        [Display(Name = "New Image_Path")]
        public string Image_Path { get; set; }
    }
    public class ChangeDonateBindingModel
    {


        public bool Donate_thr_us { get; set; }
        public string Id { get; set; }
    }
    public class ChangeUserNameBindingModel
    {


        [Display(Name = "New User")]
        

        public string NewUserName { get; set; }
    }
    public class ChangeEmailBindingModel
    {


        [Display(Name = "New Email")]

        public string NewEmail { get; set; }
    }
    public class AgeBindingModel
    {
        public string Id { get; set; }
        public int Age { get; set; }
    }
    public class requestBindingModel
    {

        public string Id { get; set; }

    }
    public class ChangeRequestBindingModel
    {

        public bool requests { get; set; }
        public string Id { get; set; }
    }
    public class ResponseBindingModel
    {

        public string response { get; set; }
        public string Id { get; set; }
    }
}
