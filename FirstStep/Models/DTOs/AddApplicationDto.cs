﻿using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace FirstStep.Models.DTOs
{
    public struct AddApplicationDto
    {
      
        
        public required int advertisement_id { get; set; }

        public required int seeker_id { get; set; }
       
        public required IFormFile cv { get; set; }

        public string? doc1_url { get; set; }

        public string? doc2_url { get; set; }
        
    }
}
