using Final_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Common
{
    public class Response
    {
        public ApplicationUser User { get; set; }
        public string Data { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
        
    }
}
