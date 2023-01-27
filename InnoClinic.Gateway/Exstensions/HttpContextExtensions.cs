using Ocelot.Configuration;
using Ocelot.Middleware;

namespace InnoClinic.Gateway
{
    public static class HttpContextExtensions
    {
        public static string GetDownStreamKey(this HttpContext context)
            => ((DownstreamRoute)context.Items["DownstreamRoute"]).Key;

        public static DownstreamResponse GetDownStreamResponse(this HttpContext context)
            => (DownstreamResponse)context.Items["DownstreamResponse"];
    }
}
