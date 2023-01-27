using InnoClinic.Gateway;
using InnoClinic.Gateway.Aggregates;
using InnoClinic.Gateway.Models;
using InnoClinic.Gateway.Models.Doctor;
using Ocelot.Middleware;
using Ocelot.Multiplexer;

public class ViewDoctors : AggregatorBase, IDefinedAggregator
{
    public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
    {
        DoctorsViewDto doctorsViewDto = new();

        foreach (var response in responses)
        {
            var downStreamResponse = response.GetDownStreamResponse();

            switch (response.GetDownStreamKey())
            {
                case "OfficeDto":
                    doctorsViewDto.Offices = await GetEntities<IEnumerable<OfficeDto>>(downStreamResponse);
                    break;
                case "DoctorDto":
                    doctorsViewDto.Doctors = await GetEntities<IEnumerable<DoctorDto>>(downStreamResponse);
                    break;
                default:
                    break;
            };
        }

        return CreateResponse(doctorsViewDto);
    }
}