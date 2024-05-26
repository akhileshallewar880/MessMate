using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessMate.API.DTO
{
    public class CreateMessDTO
    {
        public string Name { get; set; }
    public int OwnerId { get; set; }
    public string Location { get; set; }
    public bool Veg { get; set; }
    public bool NonVeg { get; set; }
    public string Timings { get; set; }
    }
}