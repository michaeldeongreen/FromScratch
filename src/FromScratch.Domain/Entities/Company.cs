using FromScratch.Domain.Interfaces;
using System;
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
        public string Name { get; set; }
    }
}
