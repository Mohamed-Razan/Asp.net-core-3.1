using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice01.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Student Student { get; set; }
    }
}
