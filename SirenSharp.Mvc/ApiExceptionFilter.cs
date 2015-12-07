using System.Threading.Tasks;

namespace SirenSharp.Mvc
{
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Web.Http.Filters;

    public class ApiExceptionFilter : IExceptionFilter
    {
        public bool AllowMultiple => false;

        public Task ExecuteExceptionFilterAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            actionExecutedContext.Response = actionExecutedContext.Request.CreateResponse(HttpStatusCode.InternalServerError, new SirenException(actionExecutedContext.Exception));
            return Task.Factory.StartNew(() => { }, cancellationToken);
        }
    }
}
