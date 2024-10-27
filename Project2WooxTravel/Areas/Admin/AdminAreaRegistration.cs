using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        // Area kısmını modüler bir yapı olsun diye yaptık yani Admin ile oluşan işlemleri burda yapacaz.
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}