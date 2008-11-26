namespace YABE.Web.Components
{
    using System;
    using System.Web.Mvc;
    using Rhino.Commons;

    public class ControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(Type controllerType)
        {
            if (controllerType == null)
            {
                return base.GetControllerInstance(controllerType);
            }

            return IoC.Resolve(controllerType) as IController;
        }
    }
}