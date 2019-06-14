using Microsoft.AspNetCore.Builder;

namespace Api.ResultWrapper.AspNetCore.Extensions
{
    //middleware helper extension class
    public static class ApiResponseMiddlewareExtension
    {
        public static IApplicationBuilder UseAPIResponseWrapperMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<APIResponseMiddleware>();
        }
    }
}
