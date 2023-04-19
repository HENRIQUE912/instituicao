using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace instituicao.Models
{
    public class instituicao
    {
        [Key]
        [Column("INSTID")]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        [Column("INSTNOME")]
        public int MyProperty { get; set; }
    }
}
