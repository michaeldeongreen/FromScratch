using FromScratch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Domain.Entities
{
    public class Employee : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("EmployeeId")]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public virtual string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public virtual string LastName { get; set; }
        public virtual Company Company { get; set; }
        [ForeignKey("Company")]
        public virtual int CompanyId { get; set; }
    }
}
