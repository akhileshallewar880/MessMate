using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.Models.Domain.DTO
{
    public class CreateSubscriptionDTO
    {
        public int UserId { get; set; }
    public int MessId { get; set; }
    public string Plan { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
    }
}