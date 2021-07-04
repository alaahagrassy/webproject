using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Graduation_project3.Models
{
    public class Submit
    {
        public int Id { get; set; }
        public BloodType submit { get; set; }
        public string AdminName { get; set; }
        public string Date { get; set; }
    }
}