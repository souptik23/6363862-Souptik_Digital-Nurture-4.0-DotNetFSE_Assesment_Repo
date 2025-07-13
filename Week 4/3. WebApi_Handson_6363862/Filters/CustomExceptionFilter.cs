using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace WebApplication1_6363862.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var message = $"[{DateTime.Now}] {exception.Message} {Environment.NewLine}";

            File.AppendAllText("logs/exceptions.txt", message); // Ensure 'logs' folder exists

            context.Result = new ObjectResult("Internal Server Error - Logged by CustomExceptionFilter")
            {
                StatusCode = 500
            };
        }
    }
}