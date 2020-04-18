namespace CvApi.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Contact
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(150)]
        public string Content { get; set; }
    }

}