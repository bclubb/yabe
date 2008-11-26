namespace YABE.Web.Components
{
    using System.Web.Routing;

    public interface IRouteManager
    {
        void RegisterRoutes(RouteCollection routes);
    }
}