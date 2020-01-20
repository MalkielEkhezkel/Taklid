using Microsoft.AspNetCore.Http;

namespace Taklid.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse responce, string message)
        {
            responce.Headers.Add("Application-Error", message);
            responce.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            responce.Headers.Add("Access-Control-Allow-Origin", "*");
        }
    }
}