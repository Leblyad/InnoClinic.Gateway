namespace InnoClinic.Gateway.Models.Appointment
{
    public class CreateAppointmentByReceptionistDto
    {
        public IEnumerable<DoctorDto> Doctors { get; set; }
        public IEnumerable<PatientDto> Patients { get; set; }
        public IEnumerable<SpecializationDto> Specializations { get; set; }
        public IEnumerable<ServiceDto> Services { get; set; }
        public IEnumerable<OfficeDto> Offices { get; set; }
    }
}
