using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2
{
    internal sealed class ExceptionActionResult : ActionResult
    {
        private readonly Exception _exception;
        internal Exception Exception { get { return _exception; } }

        public ExceptionActionResult(Exception exception)
        {
            _exception = exception;
        }

        public override async Task ExecuteResultAsync(ActionContext context)
        {
            var httpResponse = context.HttpContext.Response;
            httpResponse.Headers.Add("Exception-Type", _exception.GetType().Name);
            httpResponse.HttpContext.Features.Get<IHttpResponseFeature>().ReasonPhrase = "Huston we have a problem";
            httpResponse.StatusCode = (int)HttpStatusCode.BadRequest;
            await httpResponse.WriteAsync(_exception.Message).ConfigureAwait(false);
        }
    }
}
