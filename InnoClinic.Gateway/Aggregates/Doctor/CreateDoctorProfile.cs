using InnoClinic.Gateway.Models;
using InnoClinic.Gateway.Models.Doctor;
using Ocelot.Middleware;
using Ocelot.Multiplexer;
namespace InnoClinic.Gateway.Aggregates.Doctor
{
    public class CreateDoctorProfile : AggregatorBase, IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            CreateDoctorProfileDto createDoctorProfileDto = new();

            foreach (var response in responses)
            {
                var downStreamResponse = response.GetDownStreamResponse();

                switch (response.GetDownStreamKey())
                {
                    case "OfficeDto":
                        createDoctorProfileDto.Offices = await GetEntities<IEnumerable<OfficeDto>>(downStreamResponse);
                        break;
                    case "SpecializationDto":
                        createDoctorProfileDto.Specializations = await GetEntities<IEnumerable<SpecializationDto>>(downStreamResponse);
                        break;
                    default:
                        break;
                };
            }

            return CreateResponse(createDoctorProfileDto);
        }
    }
}
