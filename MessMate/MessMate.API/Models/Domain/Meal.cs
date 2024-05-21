using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.Models.Domain
{
    public class Meal
    {
        public Guid Id { get; set; }
        public Guid SubscriptionId { get; set; }
        public string MealType { get; set; }
        public DateOnly Date { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public Subscription Subscription { get; set; }

    }
}