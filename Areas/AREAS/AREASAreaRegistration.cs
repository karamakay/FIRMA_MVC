using System.Web.Mvc;

namespace FIRMA_MVC.Areas.AREAS
{
    public class AREASAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AREAS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AREAS_default",
                "AREAS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}