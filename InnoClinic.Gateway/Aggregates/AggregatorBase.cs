using Newtonsoft.Json;
using Ocelot.Middleware;
using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace InnoClinic.Gateway.Aggregates
{
    public abstract class AggregatorBase
    {
        public async Task<T> GetEntities<T>(DownstreamResponse downstreamResponse)
        {
            return await downstreamResponse.Content.ReadFromJsonAsync<T>();
        }

        public DownstreamResponse CreateResponse(object obj)
        {
            var appointmentsResponse = JsonConvert.SerializeObject(obj);

            var contentBuilder = new StringBuilder();
            contentBuilder.Append(appointmentsResponse);

            var stringContent = new StringContent(contentBuilder.ToString())
            {
                Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
            };

            return new DownstreamResponse(stringContent, HttpStatusCode.OK, new List<KeyValuePair<string, IEnumerable<string>>>(), "OK");
        }
    }
}
