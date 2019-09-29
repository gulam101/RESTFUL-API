using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Person
    {
        //Manually increments the value
        public int Id { get; set; } = 0; 
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
    }
}