﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.InputModels.User
{
    public class LoginInput
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string RepeatPassword { get; set; }

    }
}
