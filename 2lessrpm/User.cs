using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lessrpm
{
    partial class User
    {
        public User(int id, string? name, string email) 
        {
            this.id = id;
            this.name = name;
            Email = email;
        }
        public int id { get; set; }
        public string? name { get; set; }
        public string Email { get; set; }

    }
}
