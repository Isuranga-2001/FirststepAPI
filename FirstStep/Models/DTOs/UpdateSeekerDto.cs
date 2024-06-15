﻿using System.ComponentModel.DataAnnotations;

namespace FirstStep.Models.DTOs
{
    public class UpdateSeekerDto
    {
        public required string email { get; set; }

        public string? password { get; set; }

        public required string first_name { get; set; }

        public required string last_name { get; set; }

        public int phone_number { get; set; }

        public required string bio { get; set; }

        public required string description { get; set; }

        public string? university { get; set; }

        public string? CVurl { get; set; }

        public string? profile_picture { get; set; }

        public string? linkedin { get; set; }

        public int field_id { get; set; }

        public List<string>? seekerSkills { get; set; }

        public IFormFile? cvFile { get; set; }

        public IFormFile? profilePictureFile { get; set; } 
    }
}
