using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database
{
    [Table("Regiao")]
    public partial class Regiao
    {
        public Regiao()
        {
            Estados = new HashSet<Estado>();
        }

        [Key]
        public long CodigoRegiao { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; } = null!;

        [InverseProperty("CodigoRegiaoNavigation")]
        public virtual ICollection<Estado> Estados { get; set; }
    }
}
