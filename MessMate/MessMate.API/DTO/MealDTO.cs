using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.DTO
{
    public class MealDTO
    {
        public int Id { get; set; }
    public int SubscriptionId { get; set; }
    public string MealType { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
    }
}