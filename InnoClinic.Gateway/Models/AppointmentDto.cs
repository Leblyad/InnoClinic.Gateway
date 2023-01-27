using InnoClinic.Gateway.Models.Enums;

namespace InnoClinic.Gateway.Models
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }
        public Guid SpecializationId { get; set; }
        public Guid PatientId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid ServiceId { get; set; }
        public Guid OfficeId { get; set; }
        public string Date { get; set; }
        public string Timeslots { get; set; }
        public AppointmentStatusEnum Status { get; set; }
        public string ServiceName { get; set; }

        public DoctorDto Doctor { get; set; }
        public PatientDto Patient { get; set; }
        public ServiceDto Service { get; set; }
    }
}
