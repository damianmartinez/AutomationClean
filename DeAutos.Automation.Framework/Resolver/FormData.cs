using System.Collections.Specialized;
using System.Configuration;

namespace DeAutos.Automation.Framework.Resolver
{
    public class FormData
    {
        private static NameValueCollection formData = (NameValueCollection)ConfigurationManager.GetSection("generalConfiguration/FormDataConfiguration");

        public static string Name = formData.Get("ContactForm.Name");
        public static string LastName = formData.Get("ContactForm.LastName");
        public static string ValidEmail = formData.Get("ContactForm.Email");
        public static string AreaPhoneNumber = formData.Get("ContactForm.AreaPhoneNumber");
        public static string CompanyName = formData.Get("ContactForm.CompanyName");
        public static string PhoneNumber = formData.Get("ContactForm.PhoneNumber");
        public static string Comment = formData.Get("ContactForm.Comment");

        public static string BackofficeUser = formData.Get("User.Backoffice.Username");
        public static string EndUser = formData.Get("User.EndUser.Username");
        public static string OfficialUser = formData.Get("User.OfficialUser.Username");
        public static string MultibrandUser = formData.Get("User.MultibrandUser.Username");
        public static string SubscriptionUser = formData.Get("User.SubscriptionUser.Username");
        public static string ConversationUser = formData.Get("User.Conversation.Username");
        public static string DialogUser = formData.Get("User.Dialog.Username");
        public static string ValidOfficialUser = formData.Get("User.ValidOfficialUser.Username");

        public static string BackofficeUserPassword = formData.Get("User.Backoffice.Password");
        public static string EndUserPassword = formData.Get("User.EndUser.Password");
        public static string OfficialUserPassword = formData.Get("User.OfficialUser.Password");
        public static string MultibrandUserPassword = formData.Get("User.MultibrandUser.Password");
        public static string SubscriptionUserPassword = formData.Get("User.SubscriptionUser.Password");
        public static string ConversationUserPassword = formData.Get("User.Conversation.Password");
        public static string DialogUserPassword = formData.Get("User.Dialog.Password");
        public static string ValidOfficialUserPassword = formData.Get("User.ValidOfficialUser.Password");

        public static string BackofficeTypeOfDiscountToChoose = formData.Get("Backoffice.Discount.TypeOfDiscountToChoose");
        public static string BackofficeListingSponsorColorHexa = formData.Get("Backoffice.Listing.Prelisting.ColorHexa");
        public static string BackofficeListingSponsorTextColorHexa = formData.Get("Backoffice.Listing.Prelisting.TextColorHexa");

        public static string RegisterCompanyNamer = formData.Get("RegisterForm.CompanyName");
        public static string RegisterCuit = formData.Get("RegisterForm.Cuit");
        public static string RegisterStreetHolder = formData.Get("RegisterForm.StreetHolder");
        public static string RegisterStreetNumber = formData.Get("RegisterForm.StreetNumber");
        public static string RegisterFloor = formData.Get("RegisterForm.Floor");
        public static string RegisterDepartment = formData.Get("RegisterForm.Department");
        public static string RegisterPostalCode = formData.Get("RegisterForm.PostalCode");
        public static string RegisterFirstname = formData.Get("RegisterForm.Firstname");
        public static string RegisterLastname = formData.Get("RegisterForm.Lastname");
        public static string RegisterPassword = formData.Get("RegisterForm.Password");
        public static string RegisterPrimaryPhoneArea = formData.Get("RegisterForm.PrimaryPhoneArea");
        public static string RegisterPrimaryPhoneNumber = formData.Get("RegisterForm.PrimaryPhoneNumber");


        public static NameValueCollection FormsData
        {
            get { return formData; }
        }

        private FormData()
        {
        }
    }
}