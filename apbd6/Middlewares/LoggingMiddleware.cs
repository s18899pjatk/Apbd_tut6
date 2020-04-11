using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial6.Services;

namespace apbd6.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext, IStudentsSerivceDb serivceDb)
        {
            if (httpContext.Request != null)
            {
                string method = httpContext.Request.Method;
                string path = httpContext.Request.Path;
                string bodyStr = "";
                using (StreamReader reader = new StreamReader(httpContext.Request.Body, Encoding.UTF8, true, 1024, true))
                {
                    bodyStr = await reader.ReadToEndAsync();
                }
                string query = httpContext.Request.QueryString.ToString();
                string logStr = string.Concat("Method: ", method, '\n', "Path: ", path, '\n', "Query: ", query, '\n', "Request body:", '\n', bodyStr);
                serivceDb.logIntoFile(logStr);
            }

            if (_next != null) await _next(httpContext);
        }
    }
}
