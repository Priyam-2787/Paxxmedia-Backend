using System.ComponentModel.DataAnnotations;

namespace paxx_media.Models
{
    public class Review
    {
        [Key] // Primary key
        public int ID { get; set; }

        [Required] // UserID must not be null
        public int UserID { get; set; }

        [Required] // SpaceID must not be null
        public int SpaceID { get; set; }

        [Range(1, 5)] // Rating should be between 1 and 5
        [Required] // Rating is required
        public int Rating { get; set; }

        [MaxLength(500)] // Max length for comments (adjust as needed)
        public string? Comment { get; set; } // Optional

        [Required] // Date is required
        public DateTime Date { get; set; }
    }
}
