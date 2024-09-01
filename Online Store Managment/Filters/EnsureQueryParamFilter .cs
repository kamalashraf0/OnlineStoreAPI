using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Online_Store_Managment.Filters
{
    public class EnsureQueryParamFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Query.ContainsKey("requiredParam"))
            {
                context.Result = new BadRequestObjectResult("Missing required query parameter.");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
