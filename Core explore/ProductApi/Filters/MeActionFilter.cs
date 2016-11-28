using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProductsCore.Attributes
{
    public class MeActionFilterAttribute :Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("ACTION 1 DEBUG pre-processing logging");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // var objectContent = context.Result as ObjectContent;
            // if (objectContent != null)
            // {
            //     var type = objectContent.ObjectType; //type of the returned object
            //     var value = objectContent.Value; //holding the returned value
            // }

            Debug.WriteLine("ACTION 1 DEBUG  OnActionExecuted Response " + context.HttpContext.Response.StatusCode.ToString());
        }

        // public override async void OnActionExecuting(HttpActionContext actionContext)
        // {
        //     // pre-processing
        //     Debug.WriteLine("ACTION 1 DEBUG pre-processing logging");
        // }

        // public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        // {
        //     var objectContent = actionExecutedContext.Response.Content as ObjectContent;
        //     if (objectContent != null)
        //     {
        //         var type = objectContent.ObjectType; //type of the returned object
        //         var value = objectContent.Value; //holding the returned value
        //     }

        //     Debug.WriteLine("ACTION 1 DEBUG  OnActionExecuted Response " + actionExecutedContext.Response.StatusCode.ToString());
        // }

        // public void OnActionExecuting(ActionExecutedContext context)
        // {
        //     Debug.WriteLine("ACTION 1 DEBUG pre-processing logging");
        // }
    }
}