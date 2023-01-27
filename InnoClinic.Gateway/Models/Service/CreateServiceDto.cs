namespace InnoClinic.Gateway.Models.Service
{
    public class CreateServiceDto
    {
        public IEnumerable<ServiceCategoryDto> Categories { get; set; }
        public IEnumerable<SpecializationDto> Specializations { get; set; }
    }
}
