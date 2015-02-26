using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myApp.Models
{[Table("tblEmployee")]
    public class Employee
    {
    [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public int depID { get; set; }
        public decimal salary { get; set; }
    }
}