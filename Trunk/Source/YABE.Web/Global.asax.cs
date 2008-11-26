namespace YABE.Web
{
    using System;
    using System.Reflection;
    using System.Web.Mvc;
    using System.Web.Routing;
    using Castle.Core;
    using Components;
    using Rhino.Commons;
    using Rhino.Commons.HttpModules;

    public class MvcApplication : UnitOfWorkApplication
    {
        public override void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);

            RegisterComponents();

            ControllerBuilder.Current.SetControllerFactory(new ControllerFactory());

            //ModelBinders.DefaultBinder = new CustomModelBinder();

            var routeManager = IoC.Resolve<IRouteManager>();

            routeManager.RegisterRoutes(RouteTable.Routes);
        }

        private static void RegisterComponents()
        {
            // register all controllers
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (typeof (IController).IsAssignableFrom(type))
                {
                    IoC.Container.AddComponentLifeStyle(type.Name.ToLower(), type, LifestyleType.Transient);
                }
            }
        }
    }
}