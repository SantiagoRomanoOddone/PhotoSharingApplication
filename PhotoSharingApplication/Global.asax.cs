using PhotoSharingApplication.Models;//a
using System;
using System.Collections.Generic;
using System.Data.Entity;//a
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PhotoSharingApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // COMO ACTIVAR LA CLASE INICIALIZADORA
            //Database.SetInitializer<PhotoSharingContext>(new PhotoSharingInitializer());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
