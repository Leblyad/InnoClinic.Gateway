namespace InnoClinic.Gateway.Models
{
    public class OfficeDto
    {
        public string Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string OfficeNumber { get; set; }
        public Guid PhotoId { get; set; }
        public string RegistryPhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}
