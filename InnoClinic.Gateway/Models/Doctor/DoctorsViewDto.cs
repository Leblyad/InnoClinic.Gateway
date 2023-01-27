namespace InnoClinic.Gateway.Models.Doctor
{
    public class DoctorsViewDto
    {
        public IEnumerable<DoctorDto> Doctors { get; set; }
        public IEnumerable<OfficeDto> Offices { get; set; }
    }
}
