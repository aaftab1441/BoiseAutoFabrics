using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BA.BoiseAutoFabrics.Adapters;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BA.BoiseAutoFabrics.DataModels
{
    public class ContactUsModel
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DetroitNumber { get; set; }
        public string Comments { get; set; }
        public List<IFormFile> Attachments { get; set; }
        public string Page { get; set; }
    }
}
