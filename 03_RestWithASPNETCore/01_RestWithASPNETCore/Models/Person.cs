using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_RestWithASPNETCore.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
    }
}
