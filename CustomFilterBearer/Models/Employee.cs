using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomFilterBearer.Models
{
    public class Employee
    {
        [Key]
        public int ID;

        public string Name;
    }
}