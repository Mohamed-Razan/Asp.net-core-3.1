using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practice01.Models
{
    public class Address
    {
        public int Id { get; set; }
        public String No { get; set; }
        public String Streeet { get; set; }
        public String District { get; set; }
        public Student Student { get; set; }
    }
}
