﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitirme.BLL.Models
{
    public class StudentViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Username { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
