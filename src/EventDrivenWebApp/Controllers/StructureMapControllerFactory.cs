using System;
using System.Web.Mvc;
using System.Web.Routing;
using StructureMap;

namespace IDontEatAnimals.Web.Controllers
{
    public class StructureMapControllerFactory : DefaultControllerFactory
    {
        private readonly IContainer container;

        public StructureMapControllerFactory(IContainer container)
        {
            this.container = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
                return null;

            return (IController)container.GetInstance(controllerType);
        } 
    }
}