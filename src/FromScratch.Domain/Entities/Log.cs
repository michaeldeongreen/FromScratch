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
    public class Log : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LogId")]
        public int Id { get; set; }
        [StringLength(4000)]
        public virtual string Description { get; set; }
    }
}
