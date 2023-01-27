namespace InnoClinic.Gateway.Models.Doctor
{
    public class CreateDoctorProfileDto
    {
        public IEnumerable<OfficeDto> Offices { get; set; }
        public IEnumerable<SpecializationDto> Specializations { get; set; }
    }
}
