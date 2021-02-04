using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoForPartialViewsValidations.Models
{
    public class Employee
    {
        [Required]
        public int Empid { get; set; }
        [StringLength(20,MinimumLength =1,ErrorMessage ="Employee name cannot be less than 1 character")]
        public string Ename { get; set; }
        [MaxLength(10,ErrorMessage ="Not more than 10 chars allowed")]
        public string Deptname { get; set; }

        [EmailAddress(ErrorMessage ="Not valid")]
        public string Email { get; set; }
        [Range(10,40,ErrorMessage ="Not a valid deptno")]
        public int Deptno { get; set; }
        [Range(18,50,ErrorMessage ="Not in range")]
        public int Age { get; set; }
        [RegularExpression("http(s)?://([\\w-]+\\.)+[\\w-]+(/[\\w- ./?%&=]*)?", ErrorMessage ="Not valid url")]
        public string Url { get; set; }
    }
}