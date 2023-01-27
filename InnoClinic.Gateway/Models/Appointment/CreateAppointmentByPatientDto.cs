namespace InnoClinic.Gateway.Models.Appointment
{
    public class CreateAppointmentByPatientDto
    {
        public IEnumerable<DoctorDto> Doctors { get; set; }
        public IEnumerable<SpecializationDto> Specializations { get; set; }
        public IEnumerable<ServiceDto> Services { get; set; }
        public IEnumerable<OfficeDto> Offices { get; set; }
    }
}
