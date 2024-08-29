using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Demo01.Entities
{   //4 Ways to Mapping Classes in Database
    //1.By Convention
    //2.By Data Annotation
    //3.Fluent API -->(override OnModelCreating())
    //4.Class Confguration
    //By Convention
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public double Salary { get; set; }
    //    public int? Age { get; set; }

    //}

    //By Data Annotation
    //[Table("Employee",Schema ="dbo")]
    //internal class Employee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }
    //    [Required]
    //    [StringLength(50,MinimumLength =10)]
    //    [Column(TypeName ="varchar")]
    //    public string Name { get; set; }
    //    [Column(TypeName ="money")]
    //    public double Salary { get; set; }
    //    [Required]
    //    [Range(20,60)]
    //    public int? Age { get; set; }
    //    public string Address { get; set; }
    //    [Phone]
    //    public string Phone { get; set; }
    //    [EmailAddress]
    //    public string Email { get; set; }
    //    [NotMapped]
    //    public double TotalSalary { get; set; }
    //}

    //3.Fluent API
    
    internal class Employee
    {
       
        public int EmpId { get; set; }

        public string Name { get; set; }
        public double Salary { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        
        public string Email { get; set; }
       
        public double TotalSalary { get; set; }
    }
}
