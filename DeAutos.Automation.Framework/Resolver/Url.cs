using System.Collections.Specialized;
using System.Configuration;

namespace DeAutos.Automation.Framework.Resolver
{
    public class Url
    {
        private static NameValueCollection presentationUrls = (NameValueCollection)ConfigurationManager.GetSection("generalConfiguration/UrlPresentationConfiguration");

        public class Deautos
        {
            public class Views
            {
                public class Catalog
                {
                    public static string Main = presentationUrls.Get("CatalogUrlTest");
                    public static string Sheet = presentationUrls.Get("CatalogueVipTest");
                    public static string Sponsored = presentationUrls.Get("CatalogueSponsoredVipTest");
                    public static string Campaign = presentationUrls.Get("CampaignValidUrlTest");
                    public static string Comparator = presentationUrls.Get("ComparatorUrlTest");
                    
                }

                public class Backoffice
                {
                    public static string Main = presentationUrls.Get("BackofficeUrlTest");
                }

                public class Home
                {
                    public static string Main = presentationUrls.Get("HomeUrl");
                }

                public class Listing
                {
                    public static string Main = presentationUrls.Get("ListingUrl");
                }

                public class Vip
                {
                    public static string Sheet = presentationUrls.Get("SheetUrl");
                }

                public class MyAccount
                {
                    public static string Summary = presentationUrls.Get("MyAccountUrl");
                    public static string Publish = presentationUrls.Get("PublicationUrlTest");
                    public static string Auth = presentationUrls.Get("Auth");
                }

                public class Login
                {
                    public static string Auth = presentationUrls.Get("Auth");
                   
                }

                public class Store
                {
                    public static string Main = presentationUrls.Get("StoreUrlTest");
                }

                public class Landings
                {
                    public static string Widgets = presentationUrls.Get("WidgetsUrl");
                    public static string Landing = presentationUrls.Get("LandingUrl");
                    public static string Promo = presentationUrls.Get("PromoUrl");
                }

                public class Registers
                {
                    public static string Register = presentationUrls.Get("RegisterUrl");
                    public static string ResetPassword = presentationUrls.Get("ResetUrl");
                    public static string RegisterUserTypeTwo = presentationUrls.Get("RegisterConcesionaria");
                }
            }
        }




        public static NameValueCollection PresentationUrls
        {
            get { return presentationUrls; }
        }

    }
}