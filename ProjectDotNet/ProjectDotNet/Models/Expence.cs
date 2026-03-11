using System.ComponentModel.DataAnnotations;

namespace ProjectDotNet.Models
{
    public class Expence
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Числото трябва да е по-голямо от 0")]
        public double Amount {  get; set; }
        [Required]

        public string Category { get; set; } = null!;
        
        public DateTime Date { get; set; } = DateTime.Now;
    }
} 

