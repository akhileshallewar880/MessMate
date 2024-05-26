using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.Models.Entity
{
    public class Mess
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        [StringLength(256)]
        public string Location { get; set; }

        [Range(0, 5)]
        public float Rating { get; set; }

        [Required]
        public bool Veg { get; set; }

        [Required]
        public bool NonVeg { get; set; }

        [StringLength(100)]
        public string Timings { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey("OwnerId")]
        public User Owner { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<Feedback> Feedbacks { get; set; }
    }
}