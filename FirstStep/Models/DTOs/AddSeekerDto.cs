﻿namespace FirstStep.Models.DTOs
{
    public class AddSeekerDto
    {
        public  string email { get; set; }

        public  string password_hash { get; set; }

        public  string first_name { get; set; }

        public  string last_name { get; set; }

        public int phone_number { get; set; }

        public  string bio { get; set; }

        public  string description { get; set; }

        public string? university { get; set; }

        public  string cVurl { get; set; }

        public string? profile_picture { get; set; }

        public string? linkedin { get; set; }

        public  int field_id { get; set; }

        public virtual List<string>? seekerSkills { get; set; }
    }
}
