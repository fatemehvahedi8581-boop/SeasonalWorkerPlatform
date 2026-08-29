using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class JobAd
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public decimal Price { get; set; }
        public int EmployerId { get; set; }
        public User Employer { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

