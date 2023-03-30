using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Atacado.BD.EF.Database
{
    [Table("Cidade")]
    public partial class Cidade
    {
        [Key]
        public long CodigoCidade { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; } = null!;
        public long CodigoIBGE7 { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string UF { get; set; } = null!;
        public long CodigoEstado { get; set; }

        [ForeignKey("CodigoEstado")]
        [InverseProperty("Cidades")]
        public virtual Estado CodigoEstadoNavigation { get; set; } = null!;
    }
}
