using InnoClinic.Gateway.Models;
using InnoClinic.Gateway.Models.Service;
using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace InnoClinic.Gateway.Aggregates.Service
{
    public class CreateService : AggregatorBase, IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            CreateServiceDto createServiceDto = new();

            foreach (var response in responses)
            {
                var downStreamResponse = response.GetDownStreamResponse();

                switch (response.GetDownStreamKey())
                {
                    case "ServiceCategoryDto":
                        createServiceDto.Categories = await GetEntities<IEnumerable<ServiceCategoryDto>>(downStreamResponse);
                        break;
                    case "SpecializationDto":
                        createServiceDto.Specializations = await GetEntities<IEnumerable<SpecializationDto>>(downStreamResponse);
                        break;
                    default:
                        break;
                };
            }

            return CreateResponse(createServiceDto);
        }
    }
}
