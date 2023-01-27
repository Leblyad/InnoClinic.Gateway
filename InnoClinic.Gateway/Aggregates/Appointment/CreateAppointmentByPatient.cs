﻿using InnoClinic.Gateway.Models;
using InnoClinic.Gateway.Models.Appointment;
using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace InnoClinic.Gateway.Aggregates.Appointment
{
    public class CreateAppointmentByPatient : AggregatorBase, IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            CreateAppointmentByPatientDto createAppointmentDto = new();

            foreach (var response in responses)
            {
                var downStreamResponse = response.GetDownStreamResponse();

                switch (response.GetDownStreamKey())
                {
                    case "DoctorDto":
                        createAppointmentDto.Doctors = await GetEntities<IEnumerable<DoctorDto>>(downStreamResponse);
                        break;
                    case "SpecializationDto":
                        createAppointmentDto.Specializations = await GetEntities<IEnumerable<SpecializationDto>>(downStreamResponse);
                        break;
                    case "ServiceDto":
                        createAppointmentDto.Services = await GetEntities<IEnumerable<ServiceDto>>(downStreamResponse);
                        break;
                    case "OfficeDto":
                        createAppointmentDto.Offices = await GetEntities<IEnumerable<OfficeDto>>(downStreamResponse);
                        break;
                    default:
                        break;
                };
            }

            return CreateResponse(createAppointmentDto);
        }
    }
}
