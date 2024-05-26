using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.Models.Entity
{
    public class Meal
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid SubscriptionId { get; set; }

        [Required]
        [StringLength(50)]
        public string MealType { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        [ForeignKey("SubscriptionId")]
        public Subscription Subscription { get; set; }

    }
}