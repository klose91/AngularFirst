using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AngularFirst.Models
{
    [Table("employee")]
    public class Employee
    {
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }
        [Column("title")]
        [StringLength(20)]
        public string Title { get; set; }
        [Column("first_name")]
        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }
        [Column("last_name")]
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(255)]
        [Required]
        public string EMail { get; set; }
        [Column("account_number")]
        public string AccountNumber { get; set; }
        [Column("customer_number")]
        public string CustomerNummer { get; set; }
        public virtual Department Department { get; set; }
        [Column("department_id")]
        [Required]
        public Guid? DepartmentId { get; set; }
        [Column("consulting_email")]
        public string ConsultingEMailAddress { get; set; }
    }

    [Table("department")]
    public class Department
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid? Id { get; set; }
        [Column("name")]
        [StringLength(50)]
        public string DepartmentName { get; set; }
    }
}
