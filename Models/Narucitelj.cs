using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_zadaca_3.Models
{
    public class Narucitelj
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName+" "+LastName;
        }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
