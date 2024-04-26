﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FirstStep.Models
{
    public class Application
    {
        [Key]
        public int application_Id { get; set; }

        public required string status { get; set; }

        public required DateTime submitted_date { get; set; } = DateTime.Now;


        [JsonIgnore]
        public virtual Advertisement? advertisement { get; set; }

        public required int advertisement_id { get; set; }


        [JsonIgnore]
        public virtual Seeker? seeker { get; set; }

        public required int user_id { get; set; }


        [JsonIgnore]
        public virtual HRAssistant? assigned_hrAssistant { get; set; }
        
        public int? assigned_hrAssistant_id { get; set; }


        [JsonIgnore]
        public virtual ICollection<Revision>? revisions { get; set; }
    }
}