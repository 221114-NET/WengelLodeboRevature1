using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelsLayer
{
    public class Register
    {
        public string Email {get; set;}
        public string PhoneNumber {get; set;}
        public string Password{get; set;}
        public string ConfirmPassword {get; set;}
    }
}