namespace YABE.Web.Components
{
    using System;
    using System.ComponentModel;
    using System.Web.Mvc;

    public class CustomModelBinder : DefaultModelBinder
    {
        protected override object CreateModel(ModelBindingContext bindingContext, Type modelType)
        {
            if (IsBasicType(modelType))
            {
                return base.GetValue(controllerContext, modelName, modelType, modelState);
            }

            if (IsSimpleType(modelType))
            {
                ModelBinderResult 
            }

            var instance = Activator.CreateInstance(modelType);

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(instance))
            {
                if (IsBasicType(descriptor.PropertyType))
                {
                    var obj = GetBinder(descriptor.PropertyType).GetValue(controllerContext, descriptor.Name, descriptor.PropertyType, modelState);
                    descriptor.SetValue(instance, obj);
                }
                else
                {
                    descriptor.SetValue(instance, Activator.CreateInstance(descriptor.PropertyType));
                    BindComplexType(controllerContext, descriptor.PropertyType, descriptor.GetValue(instance), modelState);
                }
            }
            return instance;
        }

        private static void BindComplexType(ControllerContext controllerContext, Type modelType, object instance, ModelStateDictionary modelState)
        {
            string modelName = (modelType.Name.EndsWith("Entity")) ? modelType.Name.Remove(modelType.Name.Length - 6) : modelType.Name;

            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(instance))
            {
                var lookup = modelName + "." + descriptor.Name;
                var binder = GetBinder(descriptor.PropertyType);

                var obj = binder.GetValue(controllerContext, lookup, descriptor.PropertyType, modelState);

                descriptor.SetValue(instance, obj);
            }
        }
    }
}