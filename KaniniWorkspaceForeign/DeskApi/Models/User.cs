﻿using System.ComponentModel.DataAnnotations;

namespace DeskApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string? UserImagePath { get; set; }
        public string? UserFirstName { get; set; }
        public string? UserLastName { get; set; }
        public string? UserLocation { get; set; }
        public string? UserDepartment { get; set; }
        public string? UserTitle { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhoneNumber { get; set; }
        public string? UserPassword { get; set; }

        public ICollection<Desk>? Desks { get; set; }
        public ICollection<DeskBooking>? DeskBookings { get; set; }
    }
}
