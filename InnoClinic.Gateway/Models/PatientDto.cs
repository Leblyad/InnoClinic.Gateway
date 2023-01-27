﻿namespace InnoClinic.Gateway.Models
{
    public class PatientDto
    {
        public Guid Id { get; set; }
        public Guid PhotoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PhoneNumber { get; set; }
    }
}