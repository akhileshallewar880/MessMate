using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.DTO
{
    public class SubscriptionDTO
    {
        public int Id { get; set; }
    public int UserId { get; set; }
    public int MessId { get; set; }
    public string Plan { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
    }
}