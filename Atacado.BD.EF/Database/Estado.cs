using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database
{
    [Table("Estado")]
    public partial class Estado
    {
        public Estado()
        {
            Cidades = new HashSet<Cidade>();
        }

        [Key]
        public long CodigoEstado { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        [StringLength(2)]
        [Unicode(false)]
        public string UF { get; set; } = null!;
        public long CodigoRegiao { get; set; }

        [ForeignKey("CodigoRegiao")]
        [InverseProperty("Estados")]
        public virtual Regiao CodigoRegiaoNavigation { get; set; } = null!;
        [InverseProperty("CodigoEstadoNavigation")]
        public virtual ICollection<Cidade> Cidades { get; set; }
    }
}
