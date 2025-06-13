﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.Entities
{
    [Table("Doctors")]
    public class Doctor : User
    {

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        [Required]
        public int YearsOfExperience { get; set; }

        [Required]
        public string LicenseNumber { get; set; } = "";

        public ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
    }
}
