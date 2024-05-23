using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.Models.Domain.DTO
{
    public class FeedbackDTO
    {
        public int Id { get; set; }
    public int UserId { get; set; }
    public int MessId { get; set; }
    public float Rating { get; set; }
    public string Comment { get; set; }
    }
}