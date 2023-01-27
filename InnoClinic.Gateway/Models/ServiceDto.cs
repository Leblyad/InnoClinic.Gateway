namespace InnoClinic.Gateway.Models
{
    public class ServiceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public SpecializationDto Specialization { get; set; }
        public ServiceCategoryDto Category { get; set; }
    }
}
