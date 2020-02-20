using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LearnDocker.Data.Requests
{
    public class PostCandidateRequest
    {
        [Required]
        [StringLength(12, ErrorMessage = "Validation error")]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string Name { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "Validation error")]
        [RegularExpression(@"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$")]
        public string Surname { get; set; }
        [Required]
        [RegularExpression(@"^(((0)[0-9])|((1)[0-2]))(\/)([0-2][0-9]|(3)[0-1])(\/)\d{4}$")]
        public DateTime BirthDate { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
    }
}
