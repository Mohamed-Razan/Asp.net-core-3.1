using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practice01.Models
{
    public class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public List<Address> Addresses { get; set; }
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
