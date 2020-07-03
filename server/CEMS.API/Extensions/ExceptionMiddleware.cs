using CEMS.API.Models;
using CEMS.Core.Exceptions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CEMS.API.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var ResponseMessage = "A server error has occurred. Please let the system administrator know.";
            var ResponseType = "Generic Error";

            if (exception is BusinessException)
            {
                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                ResponseMessage = exception.Message;
            }
            
            return context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                StatusType = ResponseType,
                Message = ResponseMessage
            }.ToString());
        }
    }
}
