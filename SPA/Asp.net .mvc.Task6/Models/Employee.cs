using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Asp.net.mvc.Task6.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string  name { get; set; }
        [Range(18,60,ErrorMessage ="must in range 18 to 60 ")]
        public int? age { get; set; }
        
        public int Departmentid { get; set; }
        public virtual Department department { get; set; }
    }
}