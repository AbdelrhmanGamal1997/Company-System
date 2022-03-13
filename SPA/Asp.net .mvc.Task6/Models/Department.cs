using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.net.mvc.Task6.Models
{
    public class Department
    {
        [Key]
        public int Departmentid { get; set; }
        public string name { get; set; }
        public virtual ICollection<Employee> employees { get; set; }
         = new HashSet<Employee>();
        
    }
}