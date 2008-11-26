namespace YABE.Web.Components
{
    using System.Web.Mvc;

    public class ObjectResult : ActionResult
    {
        public object Model { get; set; }
        public ActionResult DefaultResult { get; set; }

        public ObjectResult()
        {
            Model = null;
            DefaultResult = null;
        }

        public ObjectResult(object model)
        {
            Model = model;
            DefaultResult = null;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            // Check for JSON or XML in Request.ContentType and serialize data accordingly

            ViewDataDictionary viewData = context.Controller.ViewData;

            viewData.Model = Model;

            // if no JSON or XML result, do default result otherwise just do viewresult

            if (DefaultResult != null)
            {
                DefaultResult.ExecuteResult(context);
                return;
            }

            var result = new ViewResult { ViewData = viewData };

            result.ExecuteResult(context);
        }
    }
}