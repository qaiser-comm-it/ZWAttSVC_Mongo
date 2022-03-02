using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ZW.AttSvc.Mongo.Authors
{
    public class UpdateAuthorDto
    {
        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ShortBio { get; set; }
    }
}
