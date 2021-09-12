using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace FizzBuzzMVC.Models
{
    public class FizzBuzzModel
    {
        public int FirstNumber { get; set; }
        public int LastNumber { get; set; }

        public List<string> Results { get; set; } = new List<string>();

    }
}
