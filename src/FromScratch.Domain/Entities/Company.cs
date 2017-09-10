using FromScratch.Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FromScratch.Domain.Entities
{
    public class Company : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CompanyId")]
        public int Id { get; set; }
        [StringLength(300)]
        public virtual string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
