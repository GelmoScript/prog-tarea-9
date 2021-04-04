using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorHostingTest.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        [MaxLength(15)]
        public string LastName { get; set; }
    }
}
