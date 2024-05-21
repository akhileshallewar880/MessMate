using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.Models.Domain
{
    public class Mess
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid OwnerId { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public int Veg { get; set; }
        public int NonVeg { get; set; }
        public DateTime Timings { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation
        public User User { get; set; }
    }
}